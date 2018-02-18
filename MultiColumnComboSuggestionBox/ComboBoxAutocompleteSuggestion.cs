using JTG;
using Microsoft.VisualBasic;
using MultiColumnComboSuggestionBox.Funtions;
using MultiColumnComboSuggestionBox.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColumnComboSuggestionBox
{
    public class ComboBoxAutocompleteSuggestion : System.Windows.Forms.ComboBox
    {
        #region Atributes
        private DataTable m_dtData;
        private DataTable DataInter;
        private DataView m_dvView;
        private bool m_bInitItems;
        private bool m_bInitSuggestionList;
        private CCBColumnCollection m_Cols;
        private int m_iViewColumn;
        private bool m_bInitDisplay;
        private StringList m_slSuggestions;
        private Keys m_kcLastKey;
        private bool m_bTextChangedInternal;
        public bool Suggest;
        private int m_iSelectedIndex;
        public bool DropDownOnSuggestion;
        private System.ComponentModel.Container components = null;
        private List<ListItemSuggestions> ListSuggestions;
        private bool isController;
        #endregion

        #region Constructor
        public ComboBoxAutocompleteSuggestion()
        {
            m_bInitItems = true;
            m_bInitSuggestionList = true;
            m_bInitDisplay = true;
            m_Cols = new CCBColumnCollection();
            m_slSuggestions = new StringList();
            ListSuggestions = new List<ListItemSuggestions>();
            m_kcLastKey = Keys.Space;
            Suggest = true;
            m_iSelectedIndex = -1;
            DropDownOnSuggestion = true;
            if (components == null)
                components = null;
            DataSourceSettig = new DataTable(); //Make sure the DataTable is not blank
            DataInter = new DataTable();
            Init();
        }
        #endregion

        #region Properties


        public DataTable DataSourceSettig
        {
            get
            {
                return m_dtData;
            }
            set
            {
                if (value == null)
                    throw new Exception("Data cannot be set to null.\r\n ColumnComboBox.Data (set)");
                m_dtData = value;
                if (!isController)
                {
                    DataInter = value;
                }
                m_dvView = new DataView(m_dtData);
                m_bInitItems = true;
                m_bInitSuggestionList = true;
                Invalidate();
            }
        }
        public int ViewColumn
        {
            get
            {
                return m_iViewColumn;
            }
            set
            {
                if (value < 0)
                    throw new Exception("ViewColumn must be greater than zero\r\n(set)ColumnComboBox.ViewColumn");
                m_iViewColumn = value;
                m_bInitItems = true;
                m_bInitDisplay = true;
                m_bInitSuggestionList = true;
            }
        }

        public uint ColumnSpacing = 4;

        public CCBColumnCollection Columns
        {
            get
            {
                if (m_bInitItems)
                    InitItems();
                if (m_bInitDisplay)
                    InitDisplay();
                return m_Cols;
            }
        }


        #endregion

        #region Methods
        private void Init()
        {
            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        }

        private void InitItems()
        {
            try
            {
                //Reset the Columns and the base.Items list
                m_Cols.Clear();
                foreach (DataColumn dc in m_dtData.Columns)
                {
                    m_Cols.Add(new CCBColumn(dc.Caption));
                }
                //Set to the first or last column if an invlid ViewColumn is specified.
                if (m_iViewColumn > m_Cols.Count - 1)
                    m_iViewColumn = m_Cols.Count - 1;
                if (m_iViewColumn < 0)
                    m_iViewColumn = 0;

                //Set up the events for the columns
                for (int index = 0; index < m_Cols.Count; index++)
                {
                    m_Cols[index].OnColumnDisplayChanged += new ChangeColumnDisplayHandler(ColumnComboBox_OnColumnDisplayChanged);
                }

                base.Items.Clear();
                //Put the stuff from the ViewColumn into the base so other base functionality will work
                foreach (DataRowView drv in m_dvView)
                {
                    string sTemp = drv[m_iViewColumn].ToString();
                    base.Items.Add(sTemp);
                }
                m_bInitItems = false;
                //Set the flag to initialize the display before next drop down
                m_bInitDisplay = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.InitItems().");
            }
        }

        private void InitDisplay()
        {
            try
            {
                //Set the widths of the columns
                int[] m_iaColWidths = new int[m_Cols.Count];
                SizeF size = new SizeF(10000, ItemHeight);//Here is a nice magic number for you but it should suffice.
                Graphics g = CreateGraphics();
                m_iaColWidths = new int[m_Cols.Count];
                //Measure each column width and set the largest size needed for each column
                foreach (DataRowView drv in m_dvView)
                {
                    for (int index = 0; index < m_Cols.Count; index++)
                    {
                        string sTemp = drv[index].ToString();
                        int iTempWidth = (int)g.MeasureString(sTemp, Font, size).Width;
                        if (iTempWidth > m_iaColWidths[index])
                            m_iaColWidths[index] = iTempWidth;
                    }
                }
                DropDownWidth = 1;
                for (int index = 0; index < m_iaColWidths.Length; index++)
                {
                    if (m_Cols[index].Width < 0) //It will be < 0 if it hasn't been initialized.
                        m_Cols[index].CalculatedWidth = m_iaColWidths[index] + (int)ColumnSpacing;
                    else
                        m_Cols[index].CalculatedWidth = m_Cols[index].Width + (int)ColumnSpacing;
                    int a = 0;
                    a++;
                    if (m_Cols[index].Display)
                        DropDownWidth += m_Cols[index].CalculatedWidth;
                }
                DropDownWidth += 16;//Another nice magic number to represent the vertical scroll bar width
                m_bInitDisplay = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.InitDisplay().");
            }
        }
        private void InitSuggestionList()
        {
            m_slSuggestions.Clear();
            ListSuggestions.Clear();

            foreach (DataRowView drv in m_dvView)
            {
                string sTemp = drv[m_iViewColumn].ToString();
                m_slSuggestions.Add(sTemp);
                ListSuggestions.Add(new ListItemSuggestions
                {
                    IndexItem = m_slSuggestions.IndexOf(sTemp),
                    NameItem = sTemp
                });

            }
        }

        private bool ExisInCurrentList(string sText)
        {
            int index = 0;
            string sFound = null;
            string sOriginal = sText;
            int iLength = sText.Length;
            int iOffset = 0;
            //see if what is currently in the text box matches anything in the string list
            for (index = 0; index < m_slSuggestions.Count; index++)
            {
                string sTemp = m_slSuggestions[index].ToUpper();
                if (sTemp.Length >= sText.Length)
                {
                    if (sTemp.IndexOf(sText, 0, sText.Length) > -1)
                    {
                        sFound = m_slSuggestions[index];
                        break;
                    }
                }
            }

            if (sFound != null)
            {
                m_bTextChangedInternal = true;
                if (DropDownOnSuggestion && !DroppedDown)
                {
                    m_bTextChangedInternal = true;
                    string sTempText = Text;
                    this.DroppedDown = true;
                    Text = sTempText;
                    m_bTextChangedInternal = false;
                }
                if (this.Text != sFound)
                {
                    this.Text += sFound.Substring(iLength);
                    this.SelectionStart = iLength + iOffset;
                    this.SelectionLength = this.Text.Length - iLength + iOffset;
                    m_iSelectedIndex = index;
                    SelectedIndex = index;
                    base.OnSelectedIndexChanged(new EventArgs());
                    return true;
                }
                else
                {
                    UpdateIndex();
                    this.SelectionStart = iLength;
                    this.SelectionLength = 0;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public DataRow getCurrentItem(int index)
        {
            int i = 0;
            if (DataSourceSettig==null || DataSourceSettig.Rows.Count ==0)
            {
                return null;
            }
            foreach (DataRow item  in this.DataSourceSettig.Rows)
            {
                if (i== index)
                {
                    return item;
                }
            }
            return null;
        }

        public void UpdateIndex()
        {
            try
            {
                if (m_bInitItems)
                {
                    InitItems();
                }

                if (m_bInitSuggestionList)
                {
                    InitSuggestionList();
                }

                string sText = Text;
                int index = 0;
                for (index = 0; index < m_dvView.Count; index++)
                {
                    if (m_dvView[index][ViewColumn].ToString() == sText)
                    {
                        if (SelectedIndex != index)
                        {
                            m_bTextChangedInternal = true;
                            m_iSelectedIndex = index;
                            SelectedIndex = index;
                            base.OnSelectedIndexChanged(new EventArgs());
                            m_bTextChangedInternal = false;
                        }
                        break;
                    }
                }
                if (index >= m_dvView.Count)
                {
                    m_bTextChangedInternal = true;
                    m_iSelectedIndex = -1;
                    SelectedIndex = -1;
                    base.OnSelectedIndexChanged(new EventArgs());
                    m_bTextChangedInternal = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.UpdateIndex().");
            }
        }

        #endregion

        #region Events
        private void ColumnComboBox_OnColumnDisplayChanged(object sender, CCBColumnEventArgs e)
        {
            //Set the flag to re-init the display before next dropdown event
            m_bInitDisplay = false;
        }
        #endregion

        #region Overrides
        protected override void OnKeyDown(KeyEventArgs e)
        {
            try
            {
                if (m_bInitSuggestionList) { }

                string sTemp = this.Text;
                InitSuggestionList();

                base.OnKeyDown(e);
                m_kcLastKey = e.KeyCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.OnKeyDown(KeyEventArgs).");
            }
        }
        

        protected override void OnTextChanged(EventArgs e) //Doesn't call the base so no wiring up this event for you.
        {
            try
            {
                //Run a few checks to make sure there should be any "suggesting" going on.
                if (m_bTextChangedInternal)//If the text is being changed by another member of this class do nothing
                {
                    m_bTextChangedInternal = false; //It will only be getting changed once internally, next time do something.
                    return;
                }

                if (!Suggest)
                    return;
                if (SelectionStart < this.Text.Length)
                    return;
                if (string.IsNullOrWhiteSpace(this.Text))
                {
                    if (DataInter.Rows.Count != DataSourceSettig.Rows.Count)
                    {
                        this.DataSourceSettig = DataInter;
                    }
                    this.DroppedDown = false;
                    return;
                }

                int iOffset = 0;
                if ((m_kcLastKey == Keys.Back) || (m_kcLastKey == Keys.Delete))//Obviously we aren't going to find anything when they push Backspace or Delete
                {
                    UpdateIndex();
                    return;
                }
                if (m_slSuggestions == null || this.Text.Length < 1)
                    return;

                //Put the current text into temp storage
                string sText;
                sText = this.Text;
                string sOriginal = sText;
                sText = sText.ToUpper();
                int iLength = sText.Length;
                string sFound = null;
                int index = 0;

                // start the filter 
                if (this.Text.Length > 2 && string.IsNullOrWhiteSpace(Strings.Right(this.Text, 1)))
                {
                    if (ExisInCurrentList(this.Text))
                    {
                        return;
                    }
                    string ColumnViewName = this.Columns[m_iViewColumn].Name;
                    //generate new data table
                    DataTable dtTemp = new GenerateDataTable(m_dtData.Columns);
                    DataTable dt1 = new GenerateDataTable(m_dtData.Columns);
                    DataTable dt2 = new GenerateDataTable(m_dtData.Columns);
                    DataTable dt3 = new GenerateDataTable(m_dtData.Columns);

                    var spliter = GetSpliter.GenerateSpliter(this.Text);
                    if (spliter.IsSucces)
                    {
                        switch (spliter.Spliter.Count())
                        {
                            case 1:
                                var datafilter = DataInter.Select(string.Format("{0} Like '%{1}%'", ColumnViewName, spliter.Spliter[0]));
                                if (datafilter != null)
                                {
                                    foreach (var item in datafilter)
                                    {
                                        dtTemp.ImportRow(item);
                                    }
                                }
                                break;
                            case 2:
                                var datafilter1 = DataInter.Select(string.Format("{0} Like '%{1}%'", ColumnViewName, spliter.Spliter[0]));
                                if (datafilter1 != null)
                                {
                                    foreach (var item in datafilter1)
                                    {
                                        dt1.ImportRow(item);
                                    }
                                }
                                var datafilter2 = dt1.Select(string.Format("{0} Like '%{1}%'", ColumnViewName, spliter.Spliter[1]));
                                if (datafilter2 != null)
                                {
                                    foreach (var item in datafilter2)
                                    {
                                        dtTemp.ImportRow(item);
                                    }
                                }
                                break;
                            case 3:

                                break;
                            default:

                                break;

                        }
                    }
                    m_bTextChangedInternal = true;
                    isController = true;
                    this.DroppedDown = false;
                    this.DataSourceSettig = dtTemp;
                    UpdateIndex();
                    m_iSelectedIndex = -1;
                    SelectedIndex = -1;
                    isController = false;
                    Text = sOriginal;
                    m_bTextChangedInternal = false;
                    base.OnSelectedIndexChanged(new EventArgs());
                    this.SelectionStart = sOriginal.Length;
                    this.SelectionLength = 0;
                    this.DroppedDown = true;

                    return;
                }

                if (DataInter.Rows.Count != DataSourceSettig.Rows.Count)
                {
                    this.DataSourceSettig = DataInter;
                    UpdateIndex();
                }
                //see if what is currently in the text box matches anything in the string list
                for (index = 0; index < m_slSuggestions.Count; index++)
                {
                    string sTemp = m_slSuggestions[index].ToUpper();
                    if (sTemp.Length >= sText.Length)
                    {
                        if (sTemp.IndexOf(sText, 0, sText.Length) > -1)
                        {
                            sFound = m_slSuggestions[index];
                            break;
                        }
                    }
                }
                //see if what is currently in the text box matches anything in the string list
                if (sFound != null)
                {
                    m_bTextChangedInternal = true;
                    if (DropDownOnSuggestion && !DroppedDown)
                    {
                        m_bTextChangedInternal = true;
                        string sTempText = Text;
                        this.DroppedDown = true;
                        Text = sTempText;
                        m_bTextChangedInternal = false;
                    }
                    if (this.Text != sFound)
                    {
                        this.Text += sFound.Substring(iLength);
                        this.SelectionStart = iLength + iOffset;
                        this.SelectionLength = this.Text.Length - iLength + iOffset;
                        m_iSelectedIndex = index;
                        SelectedIndex = index;
                        base.OnSelectedIndexChanged(new EventArgs());
                    }
                    else
                    {
                        UpdateIndex();
                        this.SelectionStart = iLength;
                        this.SelectionLength = 0;
                    }
                }
                else
                {
                    m_bTextChangedInternal = true;
                    m_iSelectedIndex = -1;
                    SelectedIndex = -1;
                    Text = sOriginal;
                    m_bTextChangedInternal = false;
                    base.OnSelectedIndexChanged(new EventArgs());
                    this.SelectionStart = sOriginal.Length;
                    this.SelectionLength = 0;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.OnTextChanged(EventArgs).");
            }
        }

        protected override void OnDropDown(EventArgs e)
        {
            try
            {
                //Initialize as required.
                if (m_bInitItems)
                    InitItems();
                if (m_bInitDisplay)
                    InitDisplay();
                base.OnDropDown(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.OnDropDown(EventArgs).");
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            try
            {
                //Keep track of this internally.
                m_iSelectedIndex = base.SelectedIndex;
                base.OnSelectedIndexChanged(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.OnSelectedIndexChanged(EventArgs).");
            }
        }
               
        //This is where the magic happens that makes it appear dropped down with multiple columns
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            try
            {
                int iIndex = e.Index;
                if (iIndex > -1)
                {
                    int iXPos = 0;
                    int iYPos = 0;

                    DataRow dr = m_dvView[iIndex].Row;
                    e.DrawBackground();
                    for (int index = 0; index < m_Cols.Count; index++) //Loop for drawing each column
                    {
                        if (m_Cols[index].Display == false)
                            continue;
                        e.Graphics.DrawString(dr[index].ToString(), Font, new SolidBrush(e.ForeColor), new RectangleF(iXPos, e.Bounds.Y, m_Cols[index].CalculatedWidth, ItemHeight));
                        iXPos += m_Cols[index].CalculatedWidth - 4;
                    }
                    iXPos = 0;
                    iYPos += ItemHeight;
                    e.DrawFocusRectangle();
                    base.OnDrawItem(e);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nIn ColumnComboBox.OnDrawItem(DrawItemEventArgs).");
            }
        }

        #endregion

    }
}

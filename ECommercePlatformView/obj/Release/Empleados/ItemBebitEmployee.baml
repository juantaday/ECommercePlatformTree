   M S B A M L   `   `   `  ���� P  LECommercePlatformView, Version=1.1.3.8, Culture=neutral, PublicKeyToken=nullk:clr-namespace:ECommercePlatformView.DebitEmployeeNameSpace,ECommercePlatformView.DebitEmployeeNameSpace  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel -    'ECommercePlatformView.ItemBebitEmployee   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Llocal:clr-namespace:ECommercePlatformView.DebitEmployeeNameSpace     Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase       � 	Resources  D   >ECommercePlatformView.DebitEmployeeNameSpace.CompleteConverter   completeConverterD   >ECommercePlatformView.DebitEmployeeNameSpace.TotalSumConverter  sumConverterF   @ECommercePlatformView.DebitEmployeeNameSpace.VisiviliteConverter  visiviliteConverterJ   DECommercePlatformView.DebitEmployeeNameSpace.DebitEmployeeCollection 	 tasks  cvsTasks �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%�   &	        &	      &	 
     &	      &	      7          �� -   8      $ ProjectName��  $ Complete��  $ DueDate��   $ 	TypeDebit��.��� -    �Name$ Grid1�� � RowDefinitions �� �� $��50 �.+��� -    ��Name$ 
CursorWait��	 � Cursor$
	 Wait��$y�	Collapsed=�&   System.Windows.Controls.DataGrid  -   
  Name$
 	dataGrid1��   CanUserAddRows .     SelectionMode$ Extended=�   HorizontalGridLinesBrush �#F39784   VerticalGridLinesBrush �#F39784$��2q����#843B30   AutoGenerateColumns .  $��12(�$��20q�   
IsReadOnly . ����  �� Source# [  �� 
GroupStyle (  "System.Windows.Controls.GroupStyle     ContainerStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value$ 0,0,0,5q���  � �� ��  �� 
TargetType" ��.R�9�  9� 
IsExpanded . ���#EC7950���#9D3B23���#402C32$��2,2,2,5q���]� $��27��.+���  �� Orientation$ 
Horizontal=�.+��� $��Total: ��$
��Bold"�$��10,0,0,0q�$��16(�$��Center=��� $
��Bold"�$��0,0,5,0q�$��16(�$��Center=�����  �� Path$
 Name��� $��(��$
��Bold"�$��0q�$��16(�$��Center=��� $��12(�$��Center=����� $ 	ItemCount��� $�� documento(s)��$��12(�$��Center=��� $��)��$
��Bold"�$��0,0,5,0q�$��16(�$��Center=�� $��Bottom=�  ��%   &	          � ColumnDefinitions �� $��* ��� $��* � �� $��* ��� $��3 �.+��� $��1��$��1��
���   �	 �� X2$ 80��
���   �$	��Top=�$��1���� $��1��$��Right=�$��Bottom=�$��14(����� $ Items� �� 	Converter# [ �� $��10,0,0,0q�$��20�� � ToolTip$ Cobrar deuda��$	��0.5q�.���� .+��� -   $��2q�$��Cobrar deuda��$��14(�$ Cobrar deuda�� J� RenderTransformOrigin$ 0.5,0.5&�$
	 Hand��
  � Tag  �� $
 Name�z�V� .~��� �� �� ! �� Angle$! 0Q�T� ����   "   HeaderTemplate" �� .R�]� 
����ح�.+��� 
����  �$��30,0,0,0q�$	��100������ $
 Name�# [  �� 
����  ����� $ 	ItemCount�#   RowStyle# �� )	  #System.Windows.Controls.DataGridRow" 	 .���  � ��$ 20����  � ��$ Center=���  � ��
 �   ���  � ��
 �����$   Columns$ 0
  *System.Windows.Controls.DataGridTextColumn
  ,  &System.Windows.Controls.DataGridColumn%   Header$% Nro. Documento��1  +System.Windows.Controls.DataGridBoundColumn&   Binding& �� *
Document+
  $% Fecha��'   Width5  /System.Windows.Controls.DataGridLengthConverter$	' 120 & �� *	DebitDate+( �� StringFormat$( {0:yyyy/MM/dd HH:mm}��
  $% Saldo deuda��$	' 120 & �� *BalaceDebit+$( {0:C2}��)   	CellStyle) �� .���  � ��$ Right=��� -   $ TextBlockNothing��$��No posee ninguna deuda..��$��20(�$
��Bold"����#242531�� $ 
Horizontal=�$��1��.+��� $�� Filter completed items ��$��Center=��� -   * ��Name$* cbCompleteFilter��$��Center=��� -   $��Remove Groups��$��10,2,2,2q��� -	   $��Group by Project/Status��$��2q�
   M S B A M L   `   `   `  ����P  LECommercePlatformView, Version=1.1.3.8, Culture=neutral, PublicKeyToken=nullk:clr-namespace:ECommercePlatformView.DebitEmployeeNameSpace,ECommercePlatformView.DebitEmployeeNameSpace  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel 5      -    'ECommercePlatformView.ItemBebitEmployee   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:ECommercePlatformView.DebitEmployeeNameSpace     5      Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase     5        � 	Resources  5      D   >ECommercePlatformView.DebitEmployeeNameSpace.CompleteConverter   completeConverterD   >ECommercePlatformView.DebitEmployeeNameSpace.TotalSumConverter  sumConverterF   @ECommercePlatformView.DebitEmployeeNameSpace.VisiviliteConverter  visiviliteConverterJ   DECommercePlatformView.DebitEmployeeNameSpace.DebitEmployeeCollection 	 tasks  cvsTasks �� Source �� SortDescriptions+  %System.ComponentModel.SortDescription   PropertyName �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName��%Q  &	        &	      &	 &     &	 9     &	 L     7    5   
   6"     5   
   6"     5   
   6%     5   
   6(   �� 5   
   -   5        8    5        5      $ ProjectName��6&     5      $ Complete��6&     5      $ DueDate��6&    5        5      $ 	TypeDebit��6+   5      5      .��5      � -   5         �Name$ Grid1��5       � RowDefinitions 5    
   �� 5!      �� 5"      $��50 �6   .+�5$   
   �� -   5         ��Name$ 
CursorWait��5$      	 � Cursor$
	 Wait��6)   $y�	Collapsed=�67   &   System.Windows.Controls.DataGrid  5%   
   -   5        
  Name$
 	dataGrid1��5%         CanUserAddRows .     SelectionMode$ Extended=�5(         HorizontalGridLinesBrush �#F39784   VerticalGridLinesBrush �#F39784$��2q�5+      ���#843B30   AutoGenerateColumns .  $��12(�5.      $��20q�5/         
IsReadOnly . ��5&      ��  �� Source# [  �� 
GroupStyle 50      (  "System.Windows.Controls.GroupStyle  52         ContainerStyle 53      �� 54       �� 
TargetType" ��6    .�55      ��  �� Property � �� �� Value$ 0,0,0,5q�67   �� 56       � �� 57   "   �� 58   &    �� 
TargetType" ��66   .R�59   *   9�  9� 
IsExpanded . ���#EC7950���#9D3B23���#402C32$��2,2,2,5q�6�   ��5:   .   ]� 5;   2   $��27��6<   .+�5<   6   ��  �� Orientation$ 
Horizontal=�6A   .+�5=   :   �� $��Total: ��6E   $
��Bold"�6T   $��10,0,0,0q�6f   $��16(�6x   $��Center=�6�   �� 5>   :   $
��Bold"�6`   $��0,0,5,0q�6r   $��16(�6�   $��Center=�6�   ��6E   ��  �� Path$
 Name�6�   �� 5?   :   $��(��6E   $
��Bold"�6N   $��0q�6`   $��16(�6k   $��Center=�6y   �� 5@   :   $��12(�6e   $��Center=�6s   ��6E   �� $ 	ItemCount�6s   �� 5A   :   $�� documento(s)��6E   $��12(�6[   $��Center=�6j   �� 5B   :   $��)��6E   $
��Bold"�6N   $��0,0,5,0q�6`   $��16(�6r   $��Center=�6�   � 5C   :   $��Bottom=�6?     5D   >   ��%   &	         5E   B   6Z   5F   ?    � ColumnDefinitions 5G   >   �� 5H   B   $��* �6S   �� 5I   B   $��* �6S    5K   >   �� 5L   B   $��* �6P   �� 5M   B   $��3 �6P   .+�5O   >   �� $��1��6C   $��1��6Q   
���   �	 �� X2$ 80��6p   
���   �$	��Top=�6�   $��1��6�   �� 5P   >   $��1��6H   $��Right=�6X   $��Bottom=�6t   $��14(�6�   ��6�   �� $ Items� �� 	Converter# [ 6�   5Q   ;   �� 5R   :   $��10,0,0,0q�6A   $��20��6S    � ToolTip$ Cobrar deuda��6_   $	��0.5q�6v   .��5S   >   �� .+�5T   B   �� -   5        $��2q�5T   l   $��Cobrar deuda��6�   $��14(�6�   $ Cobrar deuda��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $
	 Hand��6�   
  � Tag  6w   �� $
 Name�z�5U   F   V� 5V   J   .~�5W   N   �� �� 5X   N   �� 5Y   N   ! �� Angle$! 0Q�6^   T� 5Z   N   5[   K   5\   c   5]   ?   5^   ;   5_   7   5`   4   ��5b   .   �� 5c   2   5e   +   5f   '   5h      5i      5k        5o      "   HeaderTemplate" 5p      �� 5q      .R�5r      ]� 
����ح�.+�5s   "   �� 
����  �$��30,0,0,0q�6�   $	��100��6�   ��6,   �� $
 Name�# [  6�   �� 5t   "   
����  ���6,   �� $ 	ItemCount�6L   5u      5v      5x      #   RowStyle# 5{      �� 5|      )	  #System.Windows.Controls.DataGridRow" 	 6   .�5}      ��  � ��$ 20��6/   �� 5~       � ��$ Center=�6K   �� 5       � ��
 �   �63   �� 5�       � ��
 �����63   5�      $   Columns$ 5�      0
  *System.Windows.Controls.DataGridTextColumn
  5�      ,  &System.Windows.Controls.DataGridColumn%   Header$% Nro. Documento��6%   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 6=   �� *
Document+
  5�      $% Fecha��6%   '   Width5  /System.Windows.Controls.DataGridLengthConverter$	' 120 6x   & 64   �� *	DebitDate+( �� StringFormat$( {0:yyyy/MM/dd HH:mm}��6x   
  5�      $% Saldo deuda��6%   $	' 120 6q   & 6:   �� *BalaceDebit+$( {0:C2}��)   	CellStyle) 5�      �� 5�      .�5�      ��  � ��$ Right=�6U   5�      5�      5�      �� 5�   
   -   5        $ TextBlockNothing��5�      $��No posee ninguna deuda..��5�      $��20(�5�      $
��Bold"�5�      ���#2425315�      �� 5�   
   $ 
Horizontal=�6   $��1��6.   .+�5�      �� $�� Filter completed items ��6   $��Center=�68   �� 5�      -   5        * ��Name$* cbCompleteFilter��5�      $��Center=�61   5�   8   �� 5�      -   5        $��Remove Groups��5�      $��10,2,2,2q�6-   6?   �� 5�      -	   5        $��Group by Project/Status��5�      $��2q�67   6B   5�      5�      5�      
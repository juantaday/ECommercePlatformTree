   M S B A M L   `   `   `  ����P  LECommercePlatformView, Version=1.1.3.8, Culture=neutral, PublicKeyToken=null=#clr-namespace:ECommercePlatformViewECommercePlatformView  5      '    !ECommercePlatformView.MoneyDetail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ECommercePlatformView     5      .��5	      �   � ColumnDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ listViewMoneda��5      $��0��6+   $��1��6<    �� SelectionMode$ Single=�6I   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 �����64   �� 5       � ��$ 0,0,0,1q�68   5      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      ��  � 	Resources 5          BooleanToVisibilityConverter��%   &	        �� 5   "   6?   5      .+�5      �� $��CommentCheckBox��6S   $��0��6'   $��0��61   $��Show comment��6<   $y�	Collapsed=�6�    d� 	IsChecked 6j   �� 	 �� Path$	 IsSelect�6�   �� 5      $��CheckBoxIsChecken��6'   -   5        {�. y�5       �� 
 �� ElementName$
 CommentCheckBox��$	 	IsChecked� �� 	Converter# [   5$   !   �� $	 	IsChecken�
 � Tag 5'   !   �� $	 IdMonedaDetail�5(      �� 5)      $��1q�6%   $��60��60   .+�5*      �� $��60��6C   $
��Fill=�6P   ��6$   �� *ImageMoneda+6P   5+      �� 5,      $ Vertical=�6%   $��5q�6<   .+�5-      ��  ��Name$ moneda��6(   $
��Bold"�6[   $��16(�6m   ��69   �� $	 Description�6m   �� 5.      $ idMonedaDeatil��6(   $��0��6e   $��0��6o   ��6@   �� $	 IdMonedaDetail�6o   �� 5/      $ 
Horizontal=�6)   $
��Left=�6B   .+�50   "   �� $��	Cantidad:��51   %   $��4q�67   $��14(�6B   �� 52   "    ��Name$ QuantityEntry��6*   -   5        $��0��53   *   $��25��63   $��85��6?   $
��Bold"�54   *    �� TextWrapping$
 Wrap=�55   *   $��Bottom=�56   *   $��Right=�57   *   $��12(�58   *    �� MaxLines$ 1��5<   *   5=      5>      5?      5@      5B      �� 5C   
   -   5        $ listViewVillete��5C      $��1��6,   $��1��6<   $ Single=�6I   ��5D      �� 5E      " ��6   .�5F      ��  � ��
 �����64   �� 5G       � ��$ 0,0,0,1q�68   5H      ��5K      �� 5L      .R�5M      �� $ 
Horizontal=�6!   .+�5N      �� $��60��6%    5O      ��%   &	        �� 5P   "   6?   5Q      .+�5R      �� $��CommentCheckBox��6S   $��0��6'   $��0��61   $��Show comment��6<   $y�	Collapsed=�6�    6j   �� $	 IsSelect�6�   �� 5S      $��CheckBoxIsChecken��6'   -   5        {�. y�5T   !   �� $
 CommentCheckBox��$	 	IsChecked�# [   5X   !   �� $	 	IsChecken� 5[   !   �� $	 IdMonedaDetail�5\      �� 5]      $��1q�6%   $��60��60   .+�5^      �� $��60��6?   $
��Fill=�6L   ��6    �� *ImageMoneda+6L   5_      �� 5`      $ Vertical=�6!   $��5q�68   .+�5a      �� $ moneda��6$   $
��Bold"�6W   $��16(�6i   ��65   �� $	 Description�6i   �� 5b      $ idMonedaDeatil��6$   $��0��6a   $��0��6k   ��6<   �� $	 IdMonedaDetail�6k   �� 5c      $ 
Horizontal=�6%   $
��Left=�6>   .+�5d      �� $��	Cantidad:��5e   %   $��4q�67   $��14(�6B   �� 5f      $ QuantityEntry��6&   -   5        $��0��5g   *   $��25��63   $��85��6?   $
��Bold"�5h   *   $
 Wrap=�5i   *   $��Bottom=�5j   *   $��Right=�5k   *   $��12(�5l   *   $ 1��5p   *   5q      5r      5s      5t      5v      5w      5x      
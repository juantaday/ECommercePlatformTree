   M S B A M L   `   `   `  ���� P  LECommercePlatformView, Version=1.1.3.8, Culture=neutral, PublicKeyToken=null=#clr-namespace:ECommercePlatformViewECommercePlatformView  '    !ECommercePlatformView.MoneyDetail   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:ECommercePlatformView     .���   � ColumnDefinitions  �� $��1* ��� $��1* �.+��� -    ��Name$ listViewMoneda��$��0��$��1�� �� SelectionMode$ Single=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �������  � ��$ 0,0,0,1q����� .R���  �� Orientation$ 
Horizontal=�.+���  � 	Resources     BooleanToVisibilityConverter��%   &	        �� .+��� $��CommentCheckBox��$��0��$��0��$��Show comment��$y�	Collapsed=� d� 	IsChecked �� 	 �� Path$	 IsSelect��� $��CheckBoxIsChecken��-   {�. y��� 
 �� ElementName$
 CommentCheckBox��$	 	IsChecked� �� 	Converter# [   �� $	 	IsChecken�
 � Tag �� $	 IdMonedaDetail��� $��1q�$��60��.+��� $��60��$
��Fill=����� *ImageMoneda+�� $ Vertical=�$��5q�.+���  ��Name$ moneda��$
��Bold"�$��16(����� $	 Description��� $ idMonedaDeatil��$��0��$��0������ $	 IdMonedaDetail��� $ 
Horizontal=�$
��Left=�.+��� $��	Cantidad:��$��4q�$��14(���  ��Name$ QuantityEntry��-   $��0��$��25��$��85��$
��Bold"� �� TextWrapping$
 Wrap=�$��Bottom=�$��Right=�$��12(� �� MaxLines$ 1���� -   $ listViewVillete��$��1��$��1��$ Single=����� " ��.���  � ��
 �������  � ��$ 0,0,0,1q����� .R��� $ 
Horizontal=�.+��� $��60�� ��%   &	        �� .+��� $��CommentCheckBox��$��0��$��0��$��Show comment��$y�	Collapsed=� �� $	 IsSelect��� $��CheckBoxIsChecken��-   {�. y��� $
 CommentCheckBox��$	 	IsChecked�# [   �� $	 	IsChecken� �� $	 IdMonedaDetail��� $��1q�$��60��.+��� $��60��$
��Fill=����� *ImageMoneda+�� $ Vertical=�$��5q�.+��� $ moneda��$
��Bold"�$��16(����� $	 Description��� $ idMonedaDeatil��$��0��$��0������ $	 IdMonedaDetail��� $ 
Horizontal=�$
��Left=�.+��� $��	Cantidad:��$��4q�$��14(��� $ QuantityEntry��-   $��0��$��25��$��85��$
��Bold"�$
 Wrap=�$��Bottom=�$��Right=�$��12(�$ 1��
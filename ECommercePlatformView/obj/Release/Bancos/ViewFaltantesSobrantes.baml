   M S B A M L   `   `   `  ����   ECommercePlatformView2    ,ECommercePlatformView.ViewFaltantesSobrantes   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� -     �Name$  	GridPanel��.+��� -    ��Name$ listViewMoneda��$��0��$��0�� �� SelectionMode$ Single=�����  �� 
TargetType" ��.���  �� Property � �� �� Value
 �������  � ��$ 0,0,0,1q����� .R���  �� Orientation$ 
Horizontal=�.+�]� $��6,2,0,2q�$��25��.+���  �� CornerRadius$ 4��
���   �
�������$	��0.5q�$
��Left=�._��� $ Vertical=�$	��0.5q�.+��� $��1q�$��35�� � ToolTip$ Ver detalle��$	��0.5q�$��20��.���� .+��� -   $
��Ver.��$��9(�$ Ver detalle��	 J� RenderTransformOrigin$	 0.5,0.5&�

 � Tag
 �� *idCajaStado+z�V� .~��� �� ��  �� Angle$	 -90Q�T� �� $��1q�$��35��$ Ver detalle��$	��0.5q�$��20��.���� .+��� -   $��Prit.��$��8(�$ Imprimir��$	 0.5,0.5&�
 �� *idCajaStado+z�V� .~��� �� �� $	 -90Q�T� ]� $��3,8,8,8q�.+��� $ 6��
�������
�������$��2q�$	��Top=�._��� $ Vertical=�.+��� $
��auto��$��40(����� *Qnty_diference+�� $ 
Horizontal=�$��0q�.+��� $��CAJERO:��$
��auto��$��16(�
���  ���� $
��auto��$��12(�$��Bottom=�$
��Left=����� *	UserOwner+�� $ Vertical=�$��10,5,0,2q�.+��� $ 
Horizontal=�$��2q�.+��� $��Local o bodega: ���� $
��Bold"����� *LocalBodega+�� $ 
Horizontal=�$��2q�.+��� $��
RETMINAL: ���� $
��Bold"�
���� K����� *
CodTerinal+�� $ 
Horizontal=�$��1q�.+��� $��Fecha de inicio: ���� ���� *
dateStar+�� $ 
Horizontal=�$��1q�.+��� $��Fecha cierre: ���� ���� *	dateEnd+�� $ 
Horizontal=�$��1,4,1,0q�.+��� $��Nº Operación: ���� 
���  ������ *idCajaStado+�� $ Vertical=�$��20,5,0,2q�.+��� $ 
Horizontal=�$��1q�.+��� $��Inicio de divisa: ���� &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=����� *	QnttyOpen+�� $ 
Horizontal=�$��1q�.+��� $��Finaliza divisa: ���� ���� *
QnttyClose+�� $ 
Horizontal=�$��1q�.+��� $��Aperturó: ���� ���� *codUserOpen+�� $ 
Horizontal=�$��1q�.+��� $��Realizo el cierre: ���� ���� *codUserClosed+
   M S B A M L   `   `   `  ���� H  DProtectoraIPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProtectoraIPOProtectoraIPO      ProtectoraIPO.win_Ayuda   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ProtectoraIPO     -     � Title$  Ayuda��$	��550��$	��600�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Topmost .  � Icon$ Fotos/logoApp.png��.���    bordeComboBox#���   .+��� -    ��Name$ 	tc_ayudas��  TabControlClaroStyle#���  $
��8,10q�.@��� -    ��Name$ ti_lista��$��Ayudas��  TabItemClaroStyle#���  .��� .+��� -    ��Name$ lb_ayuda��$
��0,10q�  ListBoxStyle#���  ���� .R���  �� Orientation$ 
Horizontal=�.+�A� $��5��$��5��$��5q�#���   �� ���� *Titulo+�� -   $ ti_desc��$��Detalle��#���  .��� 	 � RowDefinitions	 �� $
��Auto ��� $	��50* ��� $
��Auto ��� $
��Auto �.+��� -   
 ��Name$
 
lbl_titulo��$��Label��$��Center=�$	��Top=�$��0��$
��Bold"�  
LabelStyle#���  �� -    ��Name$ img_foto��$	��0,0q�$��1��$��Uniform=��� -    ��Name$ gb_pasos��$��Pasos��$��2��$��Center=�$��Center=�$
��Auto��  GroupBoxStyle#���  .���� -	    ��Name$ sp_pasos��$��Center=�$ 
Horizontal=��� -
    ��Name$ txt_descripcion��$��Stretch=�$��
20,5,20,20q�$
��Wrap=�$��Texto��$��Stretch=�$��3��  TextBlockStyle#���  �� -   $ ti_acercaDe��$��	Acerca De��#���  .��� 	 �� $
��Auto ��� $
��Auto �.+��� $��Acerca de ProtectoraIPO��$��Center=�$	��Top=�$��0��$
��Bold"�#���  $��0,10,0,0q�� $��1��	 �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��Autores��#���  $��40,10q�.���� $��Center=�$ Vertical=�$��10q�.+��� $��Carlos Ordoño Moraleda��#���  �� $%��Yirmel Augusto Sánchez Baldera��#���  �� $��Grupo de Laboratorio��#���  $��40,10q�$��1��.���� $��Center=�$ Vertical=�$��10q�.+��� $��BC��#���  �� $��Versión��#���  $��40,10q�$��2��.��� $��2��$��10q� � ColumnDefinitions �� $
��Auto ��� $	��70* �.+��� $��0��.+��� $��
Versión: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Fecha de Versión: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��.+��� $��30��$��0,0,0,3q�{�.    TextBoxStyle#���  $��1.0.0���� $��30��$��0,0,0,3q�{�.  #���  $��10 Enero 2022��
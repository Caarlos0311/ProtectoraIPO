   M S B A M L   `   `   `  ���� H  DProtectoraIPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProtectoraIPOProtectoraIPO      ProtectoraIPO.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ProtectoraIPO     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  -     � Title$  ProtectoraIPO��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=�$	��420��$	��450�� � Icon$ Fotos/logoApp.png��.���    fondoTerciarioOscuro#���    � RowDefinitions �� $��60 ��� $
��200* ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��200* ��� $
��Auto �.+�� -    �Name$ 
Grid_Login��$��1��$��Center=�$	��300��$��1��$��Center=�$	��300��  fondoSecundarioComboBox#���  $y�Visible=� �� $	��25* ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $��5* �.+�� $��2�� �� $	��90* ��� $
��auto �.+��� -    ��Name$ txtbox_usuario��$��45��$��	10,0,10,0q�$��2�� �� TextWrapping$
 Wrap=�$��Center=�$��Center=�  TextBoxStyle#���  �� -    ��Name$ adv_usuario_lo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�	 � ToolTip$%	 Introduce un usuario registrado��� $��4�� �� $	��90* ��� $
��auto �.+�G� -   
 G�Name$
 
pss_contra��$��	10,0,10,0q�$��4��$	��Top=�$��45��$��Center=�  PasswordBoxStyle#���  �� -   $ adv_contra_lo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$	 Contraseña incorrecta���� -    ��Name$ btn_acceder��$��ACCEDER��$��Right=�$��0,0,10,0q�$��6��$��Center=�$	��130��$��45��$
��Bold"�$��18(�  ButtonP#���  �� $��INICIAR SESIÓN��$��1��$��Center=�$��10,0,0,0q�$��0��$��Bottom=�$
��Bold"�  
LabelStyle#���  �� $��Usuario��$��1��$
��Left=�$��10,0,0,0q�$��1��$��Bottom=�#���  �� $��Contraseña��$��1��$
��Left=�$��10,0,0,0q�$��3��$��Bottom=�#���  �� -   $ btn_olvideContra��$
��Left=�$��10,0,0,0q�$��6��$	��top=� � Cursor$
 Hand��#���  $��Light"���Z� ��Z� .���� $��Olvidé la contraseña��$��12(�  textoComboBox#���  �� -	   $ btn_addUsuario��$
��Left=�$��10,0,0,0q�$��6��$��Bottom=�$
 Hand��$��12(�#���  $��Light"���Z� ��Z� .���� $��Registrar Usuario��$��12(�#���  � -
   $ Grid_Contrasenia��$��1��$��Center=�$	��300��$��1��$��Center=�$	��300��#���  $y�	Collapsed=� �� $	��25* ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $��5* �.+�� $��2�� �� $	��90* ��� $
��auto �.+��� -   $ txtbox_usuarioContra��$��45��$��	10,0,10,0q�$
 Wrap=�$��Center=�$��Center=�#���  �� -   $ adv_usuario_cc��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$%	 Introduce un usuario registrado��� $��4�� �� $	��90* ��� $
��auto �.+�G� -   $
 pss_nuevaContra��$��	10,0,10,0q�$	��Top=�$��45��$��Center=�{�.  #���  �� -   $ adv_contra_cc��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$*	 $La contraseña no puede estar vacía��� $��6��$��	0,0,140,0q� �� $	��90* ��� $
��auto �.+�G� -   $
 
pss_codigo��$��	10,0,10,0q�$	��Top=�$��45��$��Center=�$��2��{�.  #���  �� -   $ adv_codigo_cc��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$	 Código incorrecto���� -   $ btn_cambiar��$��CAMBIAR��$��Right=�$��0,0,10,0q�$��6��$��Center=�$	��130��$��45��$
��Bold"�$��18(�#���  �� $��Cambiar Contraseña��$��1��$��Center=�$��10,0,0,0q�$��0��$��Bottom=�$
��Bold"�#���  �� $��Usuario��$��1��$
��Left=�$��10,0,0,0q�$��1��$��Bottom=�#���  �� $��Nueva Contraseña��$��1��$
��Left=�$��10,0,0,0q�$��3��$��Bottom=�#���  �� $��Código de Control��$��1��$
��Left=�$��10,0,0,0q�$��5��$��Bottom=�#���  �� -   $ 	btn_atras��$��Right=�$��0,25,5,0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/atras2.png��$��40��$��40��$	 Volver al login��� -   $ Grid_addUsuario_1��$��1��$��Center=�$	��300��$��1��$��Center=�$	��300��#���  $y�	Collapsed=� �� $	��25* ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $��5* �.+�� $��2�� �� $	��90* ��� $
��auto �.+��� -   $ txt_nombre_AU��$��45��$��	10,0,10,0q�$
 Wrap=�$��Center=�$��Center=�#���  �� -   $ adv_nombre_au��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$$	 El nombre no debe estar vacío��� $��4�� �� $	��90* ��� $
��auto �.+��� -   $ txt_apellidos_AU��$��	10,0,10,0q�$	��Top=�$��45��$��Center=�#���  �� -   $ adv_apellidos_au��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$*	 $Los apellidos no deben estar vacíos���� -   $ btn_siguiente��$��	Siguiente��$��Center=�$��0,0,10,0q�$��6��$��Center=�$	��130��$��45��$
��Bold"�$��18(�#���  �� $��Introduce los datos��$��1��$��Center=�$��10,0,0,0q�$��0��$��Bottom=�$
��Bold"�#���  �� $��Nombre��$��1��$
��Left=�$��10,0,0,0q�$��1��$��Bottom=�#���  �� $��	Apellidos��$��1��$
��Left=�$��10,0,0,0q�$��3��$��Bottom=�#���  �� -   $ btn_atras_AU1��$��Right=�$��0,25,5,0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/atras2.png��$��40��$��40��$	 Volver atrás��� -   $ Grid_addUsuario_2��$��1��$��Center=�$	��300��$��1��$��Center=�$	��300��#���  $y�	Collapsed=� �� $	��25* ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $	��10* ��� $
��Auto ��� $��5* �.+�� $��2�� �� $	��90* ��� $
��auto �.+��� -   $ txt_usuario_AU��$��45��$��	10,0,10,0q�$��2��$
 Wrap=�$��Center=�$��Center=�#���  �� -   $ adv_usuario_au��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$7	 1El usuario no debe estar registrado o estar vacio��� $��4�� �� $	��90* ��� $
��auto �.+�G� -   $
 pss_Contra_AU��$��	10,0,10,0q�$	��Top=�$��45��$��Center=�#���  �� -   $ adv_contra_au��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$)	 #La contraseña no debe estar vacía��� $��6��$��	0,0,140,0q� �� $	��90* ��� $
��auto �.+�G� -   $
 pss_codigo_AU��$��	10,0,10,0q�$	��Top=�$��45��$��Center=�$��2��#���  �� -    $ adv_codigo_au��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��0,0,10,0q�$	 Código incorrecto���� -!   $ btn_registrar��$��	REGISTRAR��$��Right=�$��0,0,10,0q�$��6��$��Center=�$	��130��$��45��$
��Bold"�$��18(�#���  �� $��Introduce los datos��$��1��$��Center=�$��10,0,0,0q�$��0��$��Bottom=�$
��Bold"�#���  �� $��Usuario��$��1��$
��Left=�$��10,0,0,0q�$��1��$��Bottom=�#���  �� $��Contraseña��$��1��$
��Left=�$��10,0,0,0q�$��3��$��Bottom=�#���  �� $��Código de Control��$��1��$
��Left=�$��10,0,0,0q�$��5��$��Bottom=�#���  �� -"   $ btn_atras_AU2��$��Right=�$��0,25,5,0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/atras2.png��$��40��$��40��$	 Volver atrás���� -#   $ gif_main��$��1��$��Center=�$��60��$��	0,0,0,240q�$��2��$��Center=�$	��300��"  WpfAnimatedGif.ImageBehavior   AnimatedSource$ Fotos/PerrosCorriendo.gif���� -$   $ 
nogif_main��$��1��$��Center=�$��60��$��	0,0,0,240q�$��2��$��Center=�$	��300��$��Fotos/PerrosCorriendo.gif��$y�	Collapsed=��� -%    ��Name$ lbl_logo��$��1��$��Center=�$��60��$��	0,0,0,240q�$��2��$��Center=�$	��150��
�������$y�Hidden=��� -&   $ 	btn_ayuda��$
��Left=�$��0,0,0,0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/ayuda2.png��$��40��$��40��$	 Ayuda���� -'   $ 
btn_config��$��2��$��Right=�$��0,0,0,0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/configuracion2.png��$��40��$��40��$	 Configuración��
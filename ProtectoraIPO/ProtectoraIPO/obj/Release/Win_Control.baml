   M S B A M L   `   `   `  ���� H  DProtectoraIPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProtectoraIPOProtectoraIPO  -clr-namespace:ProtectoraIPOProtectoraIPO      ProtectoraIPO.Win_Control   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5ProtectoraIPOclr-namespace:ProtectoraIPO     -localclr-namespace:ProtectoraIPO     U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  -     � Title$  ProtectoraIPO��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=�$	��700��$	��450�� � Icon$ Fotos/logoApp.png��.���    fondoTerciarioOscuro#���    � RowDefinitions �� $
��Auto ��� $
��200* ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� $
��200* ��� $
��Auto �.+��� -    ��Name$ btn_ayuda_c��$��0��$
��Left=�$��0q�$��2��$��Center=�$��50��$��50��  ButtonP#���  ��Z� ��Z� .���� $��Fotos/ayuda2.png��$��40��$��40�� � ToolTip$ Ayuda���� -   $ btn_config_c��$��2��$��Right=�$��0q�$��2��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/configuracion2.png��$��40��$��40��$ Configuración���� -   $ btn_home��$��2��$��Right=�$��0q�$��0��$��Center=�$��50��$��50��#���  ��Z� ��Z� .���� $��Fotos/casa2.png��$��32��$��32��$ Cerrar Sesión���� -    ��Name$ b_tabControl��$��1��$��1�� �� CornerRadius$ 10��	 �� Padding$	 30q�  fondoTerciarioClaro#���  ._��� -   
 ��Name$
 
tc_gestion��  TabControlClaroStyle#���  .@��� -    ��Name$ 	ti_perros��$��Perros��  TabItemClaroStyle#���  .���  �� $
��Auto ��� $
��Auto ��� $	��60* �.+�� -    �Name$ 
glb_perros�� �� $
��Auto ��� $	��90* �.+��� -	    ��Name$ sp_botones_pe�� �� Orientation$ 
Horizontal=�$��Right=�$��0,0,0,5q�.+��� -
   $ 	btn_add_p��$ Añadir Perro��  ButtonStyle#���  .���� $��Fotos/anadir2.png��$ Añadir Perro��  
ImageStyle#���  �� -   $ 	btn_udt_p��$ 
Actualizar��#���  .���� $��Fotos/actualizar2.png��$ Actualizar Perro��#���  �� -   $ 	btn_del_p��$ Borrar ��#���  .���� $��Fotos/borrar2.png��$ Borrar Perro��#���  �� -    ��Name$ 	lb_perros�� �� SelectedIndex$ 0��$��1��  ListBoxStyle#���  ���� ���� .R��� $ 
Horizontal=�.+��� $��40��$��40������ *Foto+�� $��Center=�$
��10,0q�  TextBlockStyle#���  ���� *Nombre+ � ContextMenu �� .@�m� -    m�Name$ mi_addPerros��$��Añadir Perro�� 	 MenuItemStyle#��� 	  m� Icon �� $��Fotos/anadir2.png��m� -   $ mi_udtPerros��$��Actualizar Perro��#��� 	  �� $��Fotos/actualizar2.png��m� -   $ mi_delPerros��$��Eliminar Perro��#��� 	  �� $��Fotos/borrar2.png���� -    ��Name$ 	gs_perros��$��1�� 
 GridSplitterStyle#��� 
 � $��2�� �� $
��Auto ��� $	��55* ��� $	��45* � �� $	��50* ��� $	��50* �.+�� -   $ g_accion��$
��Auto��$��2��$y�	Collapsed=�
�������.+��� -    ��Name$ lbl_accionRealizar_pe��$��Center=�$��
Actualizar��$
��Bold"�$��Center=�  
LabelStyle#���  �� $ 
Horizontal=�$��Right=�.+��� -   $ btn_cancelar_p��$��5q�#���  $ Cancelar��.���� $��Fotos/cancelar.png��#���  �� -   $ btn_aceptar_p��$��5q�#���  $ Aceptar��.���� $��Fotos/check.png��#���  �� -    ��Name$ img_foto_pe��$��
20,20,20,0q�$��1������  �� ElementName$ 	lb_perros�� �� Path$ SelectedItem.Foto��� -   $ btn_cargarImg��$��Bottom=�$��Right=�$��0,0,35,5q�{�.  $��1��$ Agregar imagen��#���  .���� $��Fotos/foto.png��$ Agregar imagen��#���  �� $��1��$��Rasgos��$��
10,10,10,0q�$��1��  GroupBoxStyle#���  .���� $
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $
��Auto �.+��  �� $
��Auto ��� $	��70* �.+��� $��0��.+��� $��Nombre: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Sexo: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Edad (meses): ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Peso (Kg): ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Raza: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��.+��  �� $	��90* ��� $
��auto �.+��� -    ��Name$ txt_nombre_wc��$��30��$��0,0,0,3q�{�.    TextBoxStyle#���  �� -   $ adv_nombre_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$% El nombre no puede estar vacío���  �� $	��90* ��� $
��auto �.+��� -    ��Name$ 
cb_sexo_wc��$��30��$��0,0,0,3q�$��Center=�{�.  .@���   ComboBoxItemStyle#���  .���� $ 
Horizontal=�.+��� $��Fotos/macho.png��$��20��$��20��$	��2,0q�$  ���� $��Macho��$	��3,0q�$ Macho��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/hembra.png��$��22��$��22���� $��Hembra��$	��5,0q�$ Hembra��#���  �� -   $ 
adv_sexo_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q��  �� $	��90* ��� $
��auto �.+��� -   $ txt_edad_wc��$��30��$��0,0,0,3q�{�.  #���  �� -   $ 
adv_edad_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$# La edad no puede estar vacía���  �� $	��90* ��� $
��auto �.+��� -   $ txt_peso_wc��$��30��$��0,0,0,3q�{�.  #���  �� -   $ 
adv_peso_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$# El peso no puede estar vacío���  �� $	��90* ��� $
��auto �.+��� -    $ txt_raza_wc��$��30��$��0,0,0,3q�{�.  #���  �� -!   $ 
adv_raza_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$# La raza no puede estar vacía��� $��1�� �� $	��50* ��� $	��50* �.+��� .+�    ProtectoraIPO.ToggleButton  -"     Name$ tbtn_sociable_wc��    ProtectoraIPO.ToggleButton   MouseLeftButtonDown$* $tbtn_sociable_wc_MouseLeftButtonDown��$��40��$��40��$��Center=�$	��0,3q�{�.  �� -#   $ lbl_sociable_p��$��No Sociable��$��Center=�#���  �� $��1��.+�  -$   $ tbtn_ppp_wc��$% tbtn_ppp_wc_MouseLeftButtonDown��$��40��$��40��$��Center=�$	��0,3q�{�.  $$ Perro Potencialmente Peligroso���� -%   $ 	lbl_ppp_p��$��No PPP��$��Center=�#���  �� $��2��$��2��$��Disabled=�$
��Auto=�$��10q�.���  �� $
��Auto ��� $
��Auto �.+�9� $��0��$��Detalles��$��10,15,10,10q�  ExpanderStyle#���  .���� $��0��$��0,3,0,0q�#���  .���  �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��Descripción: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�$	��Top=�#���  �� -&   $��txt_descripcion_wc��$��1�� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $��0,3,0,3q�{�.  #���  �� $��0��$��1��.+��� $��	Padrino: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Chip: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Fecha entrada: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Estado: ��$��Right=�$��Right=�$��35��$��5,0,5,3q�#���  �� $��1��$��1��.+��  �� $
��auto ��� $	��80* �.+��� $��0��$ 
Horizontal=�.+��� -'   $ btn_verPadrino��$
��Left=�$ Ir a Padrino��#���  .���� $��Fotos/ver3.png��$ Ir a Padrino��#���  �� -(   $ btn_QuitarPadrino��$	��5,3q�$
��Left=�{�.  #���  $ Borrar Padrino��.���� $��Fotos/borrar2.png��#���  �� -)   $ cb_padrinos_wc��$��30��$��0,3,0,3q�$��Center=�{�.  $��1������ .R��� $ 
Horizontal=�.+��� $��Center=�$��0q�#���  ���� *Nombre+�� $�� ��$��Center=�$��0q�#���  �� $��Center=�$��0q�#���  ���� *	Apellidos+�  �� $	��90* ��� $
��auto �.+��� -*   $ txt_chip_wc��$��30��$��0,0,0,3q�{�.  #���  �� -+   $ 
adv_chip_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q��  �� $	��90* ��� $
��auto �.+�(  "System.Windows.Controls.DatePicker  -,     Name$ dp_fechaEntrada_wc��$��30��$��0,0,0,3q�{�.    DatePickerStyle#���  �� --   $ adv_fecha_p��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$* $Debe de haber una fecha seleccionada���� -.   $ cb_estado_wc��$��35��$��0,0,0,3q�$��Center=�{�.  .@��� #���  .���� $ 
Horizontal=�.+��� $��Fotos/adoptado.png��$��30��$��30��$	��2,0q��� $��Adoptado��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/cuarentena.png��$��30��$��30��$	��2,0q��� $��
Cuarentena��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/reservado.png��$��30��$��30��$	��2,0q��� $��	Reservado��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/fallecido.png��$��30��$��30��$	��2,0q��� $��	Fallecido��$	��3,0q�$��Center=�#���  �� #���  $4 .No se aplica ninguno de los estados anteriores��.���� $ 
Horizontal=�.+��� $��Fotos/vacio.png��$��30��$��30��$	��2,0q��� $��NA��$	��3,0q�$��Center=�#���  9� $��1��$��1��$��Salud��$��10,15,10,10q�#���  .���� $��0,3,0,0q�#���  .���  �� $	��50* ��� $	��50* � �� $
��Auto ��� $	��50* �.+�� $��2��$��0,3,0,0q� �� $
��Auto ��� $	��50* �.+��� $$��Descripción de enfermedades: ��$
��Left=�$��30��$	��5,3q�$	��Top=�#���  �� -/   $��txt_enfermedades��$
 Wrap=� . $��1��$��3��$��0,3,0,3q�{�.  #���  �� $��1��.+�  -0   $ tbtn_vacunado_wc��$* $tbtn_vacunado_wc_MouseLeftButtonDown��$��40��$��40��$��Center=�$	��0,3q�{�.  �� -1   $ lbl_vacunado_p��$��No Vacunado��$��Center=�#���  �� $��1��$��1��.+�  -2   $ tbtn_esterilizado_wc��$. (tbtn_esterilizado_wc_MouseLeftButtonDown��$��40��$��40��$��Center=�$	��0,3q�{�.  �� -3   $ lbl_esterilizado_p��$��No Esterilizado��$��Center=�#���  �� -4   $ ti_padrinos��$��Padrinos��#���  .��� .+��  �� $
��Auto ��� $
��Auto ��� $	��60* �.+�� -5   $ glb_padrinos�� �� $
��Auto ��� $	��90* �.+��� -6   $ sp_botones_pa��$ 
Horizontal=�$��Right=�$��0,0,0,5q�.+��� -7   $ 
btn_add_pa��#���  $ Añadir Padrino��.���� $��Fotos/anadir2.png��$ Añadir Padrino��#���  �� -8   $ 
btn_udt_pa��#���  $ Actualizar Padrino��.���� $��Fotos/actualizar2.png��#���  $ Actualizar Padrino���� -9   $ 
btn_del_pa��#���  $ Borrar Padrino��.���� $��Fotos/borrar2.png��$ Borrar Padrino��#���  �� -:   $ lb_padrinos��$��1��$ 0��#���  ���� ���� .R��� $ 
Horizontal=�.+��� $��Center=�$��0q�#���  ���� *Nombre+�� $�� ��$��Center=�$��0q�#���  �� $��Center=�$��0q�#���  ���� *	Apellidos+ �� .@�m� -;   $ mi_addPadrinos��$��Añadir Padrino��#��� 	  �� $��Fotos/anadir2.png��m� -<   $ mi_udtPadrinos��$��Actualizar Padrino��#��� 	  �� $��Fotos/actualizar2.png��m� -=   $ mi_delPadrinos��$��Eliminar Padrino��#��� 	  �� $��Fotos/borrar2.png���� ->   $ gs_padrinos��$��1��#��� 
 � $��2�� �� $
��Auto ��� $	��80* �.+�� -?   $ g_accion_pa��$
��Auto��$y�	Collapsed=�
�������.+��� -@   $ lbl_accionRealizar_pa��$��Center=�$��
Actualizar��$
��Bold"�
���   �$��Center=�#���  �� $ 
Horizontal=�$��Right=�.+��� -A   $ btn_cancelar_pa��#���  $ Cancelar��.���� $��Fotos/cancelar.png��#���  �� -B   $ btn_aceptar_pa��#���  $ Aceptar��.���� $��Fotos/check.png��#���  �� $
��Auto=�$
��Auto=�$��1��.���  �� $
��Auto ��� $
��Auto ��� $��40 �.+�9� $��Datos Personales��$��
10,15,10,0q�$��0��#���  .���� #���  .���� $
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��0��$��0��.+��� $��Nombre: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Apellidos: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Teléfono: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��$��0��.+��  �� $	��90* ��� $
��auto �.+��� -C   $ txt_nombre_pa��$��30��$��0,3,0,3q�$��Center=�{�.  #���  �� -D   $ adv_nombre_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$$ El nombre no debe estar vacío���  �� $	��90* ��� $
��auto �.+��� -E   $ txt_apellidos_pa��$��30��$��0,0,0,3q�$��Center=�{�.  #���  �� -F   $ adv_apellidos_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$* $Los apellidos no deben estar vacíos���  �� $	��90* ��� $
��auto �.+��� -G   $ txt_telefono_pa��$��30��$��0,0,0,3q�$��Center=�{�.  #���  �� -H   $ adv_telefono_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$+ %El número de teléfono no es válido��9� $��0��$��Ayuda��$��10,15,10,10q�$��1��#���  .���� #���  .��� .+��� $��1��$
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��0��$��0��.+��� $��Aportación Mensual: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Forma de Pago: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Número de Cuenta: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��$��0��.+��  �� $	��90* ��� $
��auto �.+��� -I   $ txt_aportacion_pa��$��30��$��0,3,0,3q�$��Center=�{�.  #���  �� -J   $ adv_aportacion_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$6 0La cantidad de aportación mensual no es válida���  �� $	��90* ��� $
��auto �.+��� -K   $ cb_formaPago_pa��$��30��$��0,0,0,3q�$��Center=�{�.  .@��� #���  .���� $ 
Horizontal=�.+��� $��Fotos/efectivo.png��$��30��$��30��$	��2,0q��� $��Efectivo��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $!��Fotos/tarjeta-de-debito.png��$��30��$��30��$	��2,0q�$  ���� $��Tarjeta��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/transferencia.png��$��30��$��30��$	��2,0q��� $��Transferencia��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/domiciliacion.png��$��30��$��30��$	��2,0q��� $��Domiciliación��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/bizum.png��$��30��$��30��$	��2,0q��� $��Bizum��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/vacio.png��$��25��$��25��$	��2,0q��� $��NA��$	��3,0q�$��Center=�#���  �� -L   $ adv_fpago_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$6 0Debe seleccionar una forma de pago distinta a NA���  �� $	��90* ��� $
��auto �.+��� -M   $ txt_nCuenta_pa��$��30��$��0,0,0,3q�{�.  #���  �� -N   $ adv_cuenta_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$5 /El formato del número de Cuenta no es correcto��� $��2�� �� $
��Auto ��� $	��70* �.+��� $)��#Fecha de Inicio de Apadrinamiento: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  � $��1�� �� $	��90* ��� $
��auto �.+�  -O   $ dp_inicioApad_pa��$��30��$��0,0,13,3q�{�.  #���  �� -P   $ adv_fecha_pa��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$* $Debe de haber una fecha seleccionada���� -Q   $ 	ti_socios��$��Socios��#���  .��� .+��  �� $
��Auto ��� $
��Auto ��� $	��60* �.+�� -R   $ 
glb_socios�� �� $
��Auto ��� $	��90* �.+��� -S   $ sp_botones_so��$ 
Horizontal=�$��Right=�$��0,0,0,5q�.+��� -T   $ 
btn_add_so��#���  $ Añadir Socio��.���� $��Fotos/anadir2.png��#���  $ Añadir Socio���� -U   $ 
btn_udt_so��#���  $ 
Actualizar��.���� $��Fotos/actualizar2.png��#���  $ Actualizar Socio���� -V   $ 
btn_del_so��#���  $ Borrar��.���� $��Fotos/borrar2.png��#���  $ Borrar Socio���� -W   $ 	lb_socios��$��1��$ 0��#���  ���� ���� .R��� $ 
Horizontal=�.+��� $��Center=�$��0q�#���  ���� *Nombre+�� $�� ��$��Center=�$��0q�#���  �� $��Center=�$��0q�#���  ���� *	Apellidos+ �� .@�m� -X   $ mi_addSocios��$��Añadir Socio��#��� 	  �� $��Fotos/anadir2.png��m� -Y   $ mi_udtSocios��$��Actualizar Socio��#��� 	  �� $��Fotos/actualizar2.png��m� -Z   $ mi_delSocios��$��Eliminar Socio��#��� 	  �� $��Fotos/borrar2.png���� -[   $ 	gs_socios��$��1��#��� 
 � $��2�� �� $
��Auto ��� $	��80* �.+�� -\   $ g_accion_so��$
��Auto��$y�	Collapsed=�
�������.+��� -]   $ lbl_accionRealizar_so��$��Center=�$��
Actualizar��$
��Bold"�$��Center=�#���  �� $ 
Horizontal=�$��Right=�.+��� -^   $ btn_cancelar_so��#���  $ Cancelar��.���� $��Fotos/cancelar.png��#���  �� -_   $ btn_aceptar_so��#���  $ Aceptar��.���� $��Fotos/check.png��#���  �� $
��Auto=�$
��Auto=�$��1��.���  �� $
��Auto ��� $
��Auto ��� $��40 �.+�9� $��Datos Personales��$��
10,15,10,0q�$��0��#���  .���� #���  .���� $
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��0��$��0��.+��� $��Nombre: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Apellidos: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Correo: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��$��0��.+��  �� $	��90* ��� $
��auto �.+��� -`   $ txt_nombre_so��$��30��$��0,3,0,3q�{�.  #���  �� -a   $ adv_nombre_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$$ El nombre no debe estar vacío���  �� $	��90* ��� $
��auto �.+��� -b   $ txt_apellidos_so��$��30��$��0,0,0,3q�{�.  #���  �� -c   $ adv_apellidos_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$* $Los apellidos no deben estar vacíos���  �� $	��90* ��� $
��auto �.+��� -d   $ txt_correo_so��$��30��$��0,0,0,3q�{�.  #���  �� -e   $ adv_correo_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$$ El correo no debe estar vacío��9� $��0��$��Ayuda��$��10,15,10,10q�$��1��#���  .���� #���  .��� .+��� $��1��$
��Auto=�$
��Auto=�.���  �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��0��$��0��.+��� $��
Cuantía: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Forma de Pago: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Titular de la Cuenta: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Número de Cuenta: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��$��0��.+��  �� $	��90* ��� $
��auto �.+��� -f   $ txt_ayuda_so��$��30��$��0,3,0,3q�{�.  #���  �� -g   $ adv_ayuda_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$&  La cuantía no debe estar vacía���  �� $	��90* ��� $
��auto �.+��� -h   $ cb_formaPago_so��$��30��$��0,0,0,3q�$��Center=�{�.  .@��� #���  .���� $ 
Horizontal=�.+��� $��Fotos/efectivo.png��$��30��$��30��$	��2,0q��� $��Efectivo��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $!��Fotos/tarjeta-de-debito.png��$��30��$��30��$	��2,0q��� $��Tarjeta��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/transferencia.png��$��30��$��30��$	��2,0q��� $��Transferencia��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/domiciliacion.png��$��30��$��30��$	��2,0q��� $��Domiciliación��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/bizum.png��$��30��$��30��$	��2,0q��� $��Bizum��$	��3,0q�$��Center=�#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/vacio.png��$��28��$��28��$	��2,0q��� $��NA��$	��3,0q�$��Center=�#���  �� -i   $ adv_fpago_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$; 5La forma de pago seleccionada debe ser distinta de NA���  �� $	��90* ��� $
��auto �.+��� -j   $ txt_titularCuenta_so��$��30��$��0,0,0,3q�{�.  #���  �� -k   $ adv_tCuenta_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$2 ,El titular de la cuenta no debe estar vacío���  �� $	��90* ��� $
��auto �.+��� -l   $ txt_nCuenta_so��$��30��$��0,0,0,3q�{�.  #���  �� -m   $ adv_cuenta_so��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$7 1El formato del número de la cuenta no es válido���� -n   $ ti_voluntarios��$��Voluntarios��#���  .���  �� $
��Auto ��� $
��Auto ��� $	��60* �.+�� -o   $ glb_voluntarios�� �� $
��Auto ��� $	��90* �.+��� -p   $ sp_botones_vo��$ 
Horizontal=�$��Right=�$��0,0,0,5q�.+��� -q   $ 
btn_add_vo��#���  $ Añadir Voluntario��.���� $��Fotos/anadir2.png��#���  $ Añadir Voluntario���� -r   $ 
btn_udt_vo��#���  $ 
Actualizar��.���� $��Fotos/actualizar2.png��#���  $ Actualizar Voluntario���� -s   $ 
btn_del_vo��#���  $ Borrar��.���� $��Fotos/borrar2.png��#���  $ Borrar Voluntario���� -t   $ lb_voluntarios��$��1��$ 0��#���  ���� ���� .R��� $ 
Horizontal=�.+��� $��40��$��40������ *Foto+�� $��Center=�$��10,0,0,0q�#���  ���� *Nombre+�� $�� ��$��Center=�$��0q�#���  �� $��Center=�$��0q�#���  ���� *	Apellidos+ �� .@�m� -u   $ mi_addVoluntarios��$��Añadir Voluntario��#��� 	  �� $��Fotos/anadir2.png��m� -v   $ mi_udtVoluntarios��$��Actualizar Voluntario��#��� 	  �� $��Fotos/actualizar2.png��m� -w   $ mi_delVoluntarios��$��Eliminar Voluntario��#��� 	  �� $��Fotos/borrar2.png���� -x   $ gs_voluntarios��$��1��#��� 
 � $��2�� �� $
��Auto ��� $	��35* ��� $	��60* � �� $	��50* ��� $	��50* �.+�� -y   $ g_accion_vo��$
��Auto��$��2��$y�	Collapsed=�
�������$��0,0,0,0q�.+��� -z   $ lbl_accionRealizar_vo��$��Center=�$��
Actualizar��$
��Bold"�
���   �$��Center=�#���  �� $ 
Horizontal=�$��Right=�.+��� -{   $ btn_cancelar_vo��#���  $��5q�$ Cancelar����Z� ��Z� .���� $��Fotos/cancelar.png��#���  �� -|   $ btn_aceptar_vo��#���  $��5q�$ Aceptar����Z� ��Z� .���� $��Fotos/check.png��#���  �� -}   $ img_foto_vo��$��
20,20,20,0q�$��1���� -~   $ btn_cargarImg_vo��$��Bottom=�$��Right=�$��0,0,35,5q�{�.  $��1��#���  $ Agregar imagen��.���� $��Fotos/foto.png��#���  $ Agregar imagen���� $��1��$��Datos Personales��$��
10,10,10,0q�$��1��#���  .���� $
��Auto=�$
��Auto=�.���  �� $��20 ��� $��57 ��� $	��70* �.+��� $��2��.+��� $��Nombre: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��Apellidos: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��DNI: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��2��.+��  �� $	��90* ��� $
��auto �.+��� -   $ txt_nombre_vo��$��30��$��0,0,0,3q�{�.  #���  �� -�   $ adv_nombre_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$$ El nombre no debe estar vació���  �� $	��90* ��� $
��auto �.+��� -�   $ txt_apellidos_vo��$��30��$��0,0,0,3q�{�.  #���  �� -�   $ adv_apellidos_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$* $Los apellidos no deben estar vaciós���  �� $	��90* ��� $
��auto �.+��� -�   $ 
txt_dni_vo��$��30��$��0,0,0,3q�{�.  #���  �� -�   $ 
adv_dni_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$! El DNI no debe estar vació���� $��2��$��2��$��Disabled=�$
��Auto=�$��10q�.���  �� $
��Auto ��� $
��Auto �.+�9� $��0��$��Datos de Contacto��$��10,15,10,10q�#���  .���� #���  .��� $��0,3,0,0q� �� $
��Auto ��� $	��70* �.+��� .+��� $��Correo: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�#���  �� $��Teléfono: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $��1��$��1��.+��  �� $	��90* ��� $
��auto �.+��� -�   $ txt_correo_vo��$��30��$��0,3,0,3q�{�.  #���  �� -�   $ adv_correo_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$$ El correo no debe estar vació���  �� $	��90* ��� $
��auto �.+��� -�   $ txt_telefono_vo��$��30��$��0,0,0,3q�{�.  #���  �� -�   $ adv_telefono_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$7 1El número de teléfono introducido no es válido��9� $��1��$��1��$��Disponibilidad��$��10,15,10,10q�#���  .���� $��0��$��0,3,0,0q�#���  .��� $��0,3,0,0q� �� $
��Auto ��� $	��70* � �� $
��Auto ��� $	��70* �.+��� $��	Horario: ��$��Right=�$��Right=�$��30��$��5,3,5,3q�$	��Top=�#���  � $��1�� �� $	��90* ��� $
��auto �.+��� -�   $��txt_horario_vo��$
 Wrap=� . $��0,3,0,3q�{�.  $��Center=�#���  �� -�   $ adv_horario_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$% El horario no debe estar vacío���� $��0��$��1��.+��� $��Zona de Actuación: ��$��Right=�$��Right=�$��30��$��5,0,5,3q�#���  �� $"��Conocimientos Veterinarios: ��$��Right=�$��Right=�$��30��$��5,5,5,3q�$��Center=�#���  �� $��1��$��1��.+��  �� $	��90* ��� $
��auto �.+��� -�   $ txt_zona_vo��$��30��$��0,0,0,3q�{�.  $��Center=�#���  �� -�   $ adv_zona_vo��$��30��$��30��$y�	Collapsed=�$��Fotos/aviso.png��$��1��$��	10,0,10,0q�$0 *La zona de actuación no debe estar vacía���� $��1��$ 
Horizontal=�.+�  -�   $ tbtn_conocimientos_vo��$/ )tbtn_conocimientos_vo_MouseLeftButtonDown��$��40��$��40��$��Center=�$	��0,3q�{�.  �� -�   $ lbl_conocimientos��$��Center=�$��Center=�$��No posee��#���  �� -�   $ 	ti_listas��$��Listas��#���  .���  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $ 
Horizontal=�.+��� $��Lista: ��$��Right=�$
��Left=�$��30��$��5,3,5,3q�$	��Top=�#���  �� -�   $ cb_lista��$��Center=�.@��� $��Perros��$ Perros��#���  �� $��Padrinos��$ Padrinos��#���  �� $��Socios��$ Socios��#���  �� $��Voluntarios��$ Voluntarios��#���  �� -�   $ btn_ver��$
��Left=�$
��20,0q�#���  $ Ir a ��.���� $��Fotos/ver3.png��#���  $- 'Ir a la vista del elemento seleccionado��&   System.Windows.Controls.DataGrid  -�      Name$  	dg_perros��$��5q�$��1��!   AutoGenerateColumns! .    DataGridStyle#���    DataGridCellStyle"   	CellStyle#" �    DataGridColumnHeaderStyle#   ColumnHeaderStyle## �  $
��Left=�$   Columns$ 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn%   Header$% Foto  ��&   CellTemplate& �� .R��� $��40��$��40������ *Foto+0  *System.Windows.Controls.DataGridTextColumn  $% Nombre  ��'   
IsReadOnly' . 1  +System.Windows.Controls.DataGridBoundColumn(   Binding( �� *Nombre+  $% Raza  ��' . ( �� *Raza+  $% Sexo  ��& �� .R��� $ 
cb_sexo_li��$
��Auto��$��Center=�{�.   �� *Sexo+.@��� #���  .���� $ 
Horizontal=�.+��� $��Fotos/macho.png��$��20��$��20��$	��2,0q�$  ���� $��Macho��$	��3,0q�$ Macho��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/hembra.png��$��22��$��22���� $��Hembra��$	��5,0q�$ Hembra��#���    $% Edad  ��' . ( �� *Edad+  $% Peso  ��' . ( �� *Peso+4	  .System.Windows.Controls.DataGridCheckBoxColumn	  $% PPP  ��' . ( �� *Ppp+	  $% 
Sociable  ��' . ( �� *
Sociable+	  $% 
Vacunado  ��' . ( �� *
Vacunado+	  $% Esterilizado  ��' . ( �� *Esterilizado+  $% Chip  ��' . ( �� *Chip+  $% Fecha de Entrada  ��& �� .R�  $��0q�{�.  #���  )   SelectedDate) �� *FechaEntrada+  $% Estado  ��& �� .R��� $
��Auto��$��Center=�{�.   �� *Estado+.@��� #���  .���� $ 
Horizontal=�.+��� $��Fotos/adoptado.png��$��30��$��30��$	��2,0q�$  ���� $��Adoptado��$	��3,0q�$��Center=�$ Adoptado��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/cuarentena.png��$��30��$��30��$	��2,0q��� $��
Cuarentena��$	��3,0q�$��Center=�$ 
Cuarentena��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/reservado.png��$��30��$��30��$	��2,0q�$  ���� $��	Reservado��$	��3,0q�$��Center=�$ 	Reservado��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/fallecido.png��$��30��$��30��$	��2,0q��� $��	Fallecido��$	��3,0q�$��Center=�$ 	Fallecido��#���  �� #���  .���� $ 
Horizontal=�.+��� $��Fotos/vacio.png��$��30��$��30��$	��2,0q��� $��NA��$	��3,0q�$��Center=�$ NA��#���    -�   $  dg_padrinos��$��5q�$��2��$y�	Collapsed=�! .  #���  #" �  ## �  $
��Left=�$   $% Nombre  ��' . ( �� *Nombre+  $% Apellidos  ��' . ( �� *	Apellidos+  $% 
Telefono  ��' . ( �� *
Telefono+  $% Aportación Mensual  ��' . ( �� *AportacionMensual+  $% Forma de Pago  ��& �� .R��� $��30��$��Center=�{�.   �� *	FormaPago+.@��� $��Efectivo���� $��Tarjeta���� $��Transferencia���� $��Domiciliación���� $��Bizum���� $��NA��  $% Número de Cuenta  ��' . ( �� *NumeroCuenta+  $&%  Fecha de Inicio Apadrinamiento  ��& �� .R�  $��0q�{�.  ) �� *FechaComienzoApadrinamiento+  -�   $  	dg_socios��$��5q�$��3��$y�	Collapsed=�! .  #���  #" �  ## �  $
��Left=�$   $% Nombre  ��' . ( �� *Nombre+  $% Apellidos  ��' . ( �� *	Apellidos+  $% Correo  ��' . ( �� *Correo+  $% Ayuda  ��' . ( �� *CuantiaAyuda+  $% Forma de Pago  ��& �� .R��� $��30��$��Center=�{�.   �� *	FormaPago+.@��� $��Efectivo���� $��Tarjeta���� $��Transferencia���� $��Domiciliación���� $��Bizum���� $��NA��  $% Titular de la Cuenta  ��' . ( �� *TitularCuenta+  $% Número de Cuenta  ��' . ( �� *NumeroCuenta+  -�   $  dg_voluntarios��$��5q�$��4��$y�	Collapsed=�! .  $��Center=�#���  #" �  ## �  $
��Left=�$   $% Foto  ��& �� .R��� $��40��$��40������ *Foto+  $% Nombre  ��' . ( �� *Nombre+  $% Apellidos  ��' . ( �� *	Apellidos+  $% DNI  ��' . ( �� *Dni+  $% Correo  ��' . ( �� *Correo+  $% Teléfono  ��' . ( �� *
Telefono+  $% 	Horario  ��' . ( �� *HorarioDisponibilidad+  $% Zona de Actuación  ��' . ( �� *ZonaActuacion+	  $"% Conocimientos Veterinarios  ��' . ( �� *ConocimientosVeterinarios+�� -�   $ gif_control��$��1��$
��Left=�$��60��$��	20,20,0,0q�$��2��$	��Top=�$	��250��"
  WpfAnimatedGif.ImageBehavior* 
  AnimatedSource$* Fotos/PerrosCorriendo.gif��$��RightToLeft=��� -�   $ nogif_control��$��1��$
��Left=�$��60��$��	20,20,0,0q�$��2��$	��Top=�$	��250��$��Fotos/PerrosCorriendo.gif��$��RightToLeft=�$y�	Collapsed=��� $ 
Horizontal=�$��1��$��2��$��Center=�.+��� $��Bienvenido ��$
��Left=�$��Center=�
�������#���  �� -�   $ lbl_nombre_is��$
��Left=�$��Center=�  
bordeClaro#���  #���  �� $�� ��$
��Left=�$��Center=�
�������#���  �� -�   $ lbl_apellidos_is��$
��Left=�$��Center=�#���  #���  �� $��. Último acceso: ��$
��Left=�$��Center=�
�������#���  �� -�   $ lbl_ultimoInicio_is��$
��Left=�$��Center=�#���  #���  
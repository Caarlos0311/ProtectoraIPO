   M S B A M L   `   `   `  ����W  SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   fondoComboBox  �� Color  fondoSecundarioComboBox  bordeComboBox  textoComboBox  
fondoClaro  fondoSecundarioClaro  fondoTerciarioClaro  
textoClaro  textoSecundarioClaro 	 
bordeClaro 
 principalClaro  fondoOscuro  fondoSecundarioOscuro  fondoTerciarioOscuro  textoOscuro  textoSecundarioOscuro  bordeOscuro  principalOscuro  
LabelStyle �� 
TargetType �� Property �� Value  TextBlockStyle  TextBoxStyle  PasswordBoxStyle  ButtonStyle  
ImageStyle  ExpanderStyle  GroupBoxStyle  ComboBoxItemStyle  DatePickerStyle(   "System.Windows.Controls.DatePicker  ListBoxStyle  DataGridStyle&   System.Windows.Controls.DataGrid  DataGridCellStyle*  $System.Windows.Controls.DataGridCell  DataGridColumnHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader   MenuItemStyle ! TabItemClaroStyle �� 
TargetType J� SnapsToDevicePixels �� CornerRadius �� Triggers P� Property	 P� Value " TabControlClaroStyle
 � RowDefinitions K� IsItemsHost # TabItemOscuroStyle $ TabControlOscuroStyle % GridSplitterStyle & ComboBoxToggleButton � ColumnDefinitions ��Name F�Name �� 
TargetName ' ComboBoxTextBox �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency � ActualWidth �� MaxDropDownHeight-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation  P� 
SourceName! �� Triggers ( ScrollBarLineButton ) ScrollBarPageButton * ScrollBarThumb + VerticalScrollBar" ]� DecreaseRepeatButton# ]� Thumb$ ]� IncreaseRepeatButton , HorizontalScrollBar - FavsScrollViewer% �� VerticalOffset& � Value' �� ScrollableHeight( � Maximum) �� ViewportHeight* �� ViewportSize*+ �� #ComputedVerticalScrollBarVisibility, �� Orientation- �� HorizontalOffset. �� ScrollableWidth/ �� ViewportWidth,0 �� %ComputedHorizontalScrollBarVisibility . btnT / ButtonP1 �� 
StartPoint2 �� EndPoint3 � Color4 � Offset5 �� Padding 0 ShadowStyle6 T� X7 T� Y 1 MyFocusVisual8 �� StrokeDashArray9 � ActualHeight�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %WB  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 )    &	
 J    &	 k    &	 �    &	 �    &	 �    &	 �    &	     &	 1    &	 R    &	     &	 �    &	 �    &	 �    &	     &	 w    &	 �    &	 �    &	 	    &	 �	    &	 �
    &	 �    &	 G    &	  �    &	! A    &	" @    &	# �    &	$ �    &	% �    &	& ]    7  &	' $    '�� �    7 ' &	( '    &	) �)    &	* +    &	+ �,    7 ( 7 ) 7 * 7 ) 7 ( &	, �/    7 ( 7 ) 7 * 7 ) 7 ( '�� �2    7 , 7 + &	- �4    &	. 77    &	/ '8    &	0 �>    &	1 �>    �� 5      $  #fff1b2��6,   �� 5      $  #FFDD9E��66   �� 5      $  #ffab6c��6,   �� 5      $  #000000��6,   �� 5      $  #fff1b2��6)   �� 5      $  #FFDD9E��63   �� 5      $  #ffffdc��62   �� 5      $  #000000��6)   �� 5      $  #1e1e1e��63   �� 5      $  #ffab6c��6)   �� 5      $  #ffc043��6-   �� 5      $  #2d2d30��6*   �� 5      $  #1e1e1e��64   �� 5      $  #3e3e42��63   �� 5      $  #FFFFFF��6*   �� 5      $  #fff1b2��64   �� 5      $  #48484c��6*   �� 5      $  #ffca4d��6.   �� 5      " ��6   .�5   
   ��  � ��# �  6'   �� 5   
    � ��$ 18(�6%   �� 5   
    � ��$ Center=�65   �� 5    
    � ��$ 0q�6$   5!      �� 5#      " ��6#   .�5$   
   ��  � ��# �  6'   �� 5%   
    � ��$ 18(�6%   �� 5&   
    � ��$ Center=�6.   �� 5'   
    �@��Padding$ 0q�6$   5(      �� 5*      " ��6!   .�5+   
   ��  � ��# �  6'   �� 5,   
    � ��# �  6'   �� 5-   
    � ��# � 	 6(   �� 5.   
    � ��$ 18(�6%   �� 5/   
    � ��$ Center=�65   �� 50   
    � ��$ 0q�6$   51      �� 53      " G�6%   .�54   
   ��  � ��# �  6'   �� 55   
    � ��# �  6'   �� 56   
    � ��# � 	 6(   �� 57   
    � ��$ 18(�6%   �� 58   
    � ��$ Center=�65   �� 59   
    � ��$ 0q�6$   5:      �� 5<      " ��6    .�5=   
   ��  � ��
 ���� 6'   �� 5>   
    � ��$ 0q�6,   �� 5?   
    � ��
 ���� 6(   �� 5@   
    � ��$ Bottom=�6.   �� 5A   
    � ��$ 30��6"   �� 5B   
    � ��$ 30��6#   �� 5C   
    � ��$	 5,0q�6#   �� 5D   
    �@�Cursor$
 Hand��6#   5E      �� 5G      " ��6   .�5H   
   ��  � ��$ 25��6"   �� 5I   
    � ��$ 25��6#   5J      �� 5L      " 9�6"   .�5M   
   ��  � ��# �  6'   �� 5N   
    � ��$ 18(�6%   5O      �� 5Q      " ��6"   .�5R   
   ��  � ��# �  6'   �� 5S   
    � ��# �  6'   �� 5T   
    � ��# � 	 6(   �� 5U   
    � ��$ 18(�6%   5V      �� 5X      " ��6&   .�5Y   
   ��  � ��# �  6'   �� 5Z   
    � ��# �  6'   �� 5[   
    � ��$ 18(�6%   5\      �� 5^      "   6$   .�5_   
   ��  � ��# �  6'   �� 5`   
    � ��# �  6'   �� 5a   
    � ��# � 	 6(   �� 5b   
    � ��$ 18(�6%   �� 5c   
    � ��$ Center=�65   5d      �� 5f      " ��6!   .�5g   
   ��  � ��# �  6'   �� 5h   
    � ��# �  6'   �� 5i   
    � ��# � 	 6(   �� 5j   
    � ��$ 18(�6%   �� 5k   
    � ��$ Center=�65   5l      �� 5n      "  6"   .�5o   
   ��  � ��# �  6'   �� 5p   
    � ��# � 	 6(   �� 5q   
    � ��$ 18(�6%   �� 5r   
    � ��$ Center=�65   �� 5s   
   # �@ VerticalScrollBarVisibility$
 Auto=�68   5t      �� 5v      "  6&   .�5w   
   ��  � ��# �  6'   �� 5x   
    � ��# � 	 6(   �� 5y   
    � ��# �  6'   5z      �� 5|      "  6.   .�5}   
   ��  � ��# � 
 6'   5~      �� 5�      " m�6"   .�5�   
   ��  � ��# �  6'   �� 5�   
    � ��# �  6'   �� 5�   
    � ��$ 18(�6%   �� 5�   
    � ��$ Center=�65   5�      �� 5�      " ��6&   .�5�   
   ��  � ��# �  6'   �� 5�   
    � ��# �  6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 0 0 5 0q�6#   �� 5�   
    � ��$	 100��6"   �� 5�   
    � ��$ 10 10q�6$   �� 5�   
    � ��$
 Bold"�6'   �� 5�   
    � ��$ 15(�6%   �� 5�   
    � ��$	 Top=�6.   �� 5�   
    � ��$
 Left=�60   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �  . .+�5�      �� $ 5��6!   #��z��5�   %   #��z��5�   %   #��z��5�   %   #��z��5�   %   �� 5�      $��Center=�6+   $��Center=�5�   /    . ��. #��z��5�   /   $��Header��5�   /   |�.  5�   /   5�       5�      P� 5�       �@J�IsMouseOver	 . . �5�      �� # �  6;    � ���� 5�      # �  6;    � ��5�      P� 5�       �@��
IsSelected	 . . �5�      �� # �  6;    � ���� 5�      # �  6;    � ��5�      5�      5�      5�      �� 5�      " ��6)   .�5�   
   ��  � ��# �  6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 5q�6$   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �  . 
 5�      �� 5�      $��50 �6,   �� 5�      $��* �6,   .+�5�      �� $��0��6#   
������  . $��Center=�5�   :   �� 5�      $��1��6!   $ 5��6.   #��z��6?   #��z��5�   %   #��z��6Q   ._�5�      �� $��SelectedContent��6/    . #��z��5�   3   5�      5�      5�      5�      5�      �� 5�      " ��6'   .�5�   
   ��  � ��# �  6'   �� 5�   
    � ��# �  6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 0 0 5 0q�6#   �� 5�   
    � ��$	 100��6"   �� 5�   
    � ��$ 10 10q�6$   �� 5�   
    � ��$
 Bold"�6'   �� 5�   
    � ��$ 15(�6%   �� 5�   
    � ��$	 Top=�6.   �� 5�   
    � ��$
 Left=�60   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �  . .+�5�      �� $ 5��6!   #��z��5�   %   #��z��5�   %   #��z��5�   %   #��z��5�   %   �� 5�      $��Center=�6+   $��Center=�5�   /    . ��. #��z��5�   /   $��Header��5�   /   |�.  5�   /   5�       5�      P� 5�       �@J�IsMouseOver	 . . �5�      �� # �  6;    � ���� 5�      # �  6;    � ��5�      P� 5�       �@��
IsSelected	 . . �5�      �� # �  6;    � ���� 5�      # �  6;    � ��5�      5�      5�      5�      �� 5�      " ��6*   .�5�   
   ��  � ��# �  6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
    � ��
 ���� 6(   �� 5�   
    � ��$ 5q�6$   �� 5   
    � �� 5     �� 5     " ��6"   .R�5     �  . 
 5     �� 5     $��50 �6,   �� 5     $��* �6,   .+�5     �� $��0��6#   
������  . $��Center=�5	  :   �� 5
     $��1��6!   $ 5��6.   #��z��6?   #��z��5  %   #��z��6Q   ._�5     �� $��SelectedContent��6/    . #��z��5  3   5     5     5     5     5     �� 5     " ��6&   .�5  
   ��  � ��# � 	 6'   �� 5  
    � ��$ 5��6"   �� 5  
    � ��$ Stretch=�60   5     �� 5     " d�63   .R�5  
   �  5     �� 5     �� 5      $��20 �6#   .+�5"     �� $ Border��5#     $��2��5$     $ 2��5%     #���   5&     #���  5'     $��1q�5(     �� 5)     $��0��5*     $ 2,0,0,2��5+     $��1q�5,     #���   5-     #���  5.     $��0,0,1,0q�5/     F� 50     $ Arrow��51     $��1��52     8��  $��Center=�54     $��Center=�55     "����        � 	=  	= � z     	56     57      58  
   P� 59      �@J�IsMouseOver	 . . �5:     �� $ Border��6   # �  6C    � ��5;     P� 5<      �@d�	IsChecked$
	 trueY�68   . �5=     �� $ Border��6   # �  6C    � ��5>     P� 5?      � {�	 .  . �5@     �� $ Border��6   # �  6C    � ���� 5A     $ Border��6   # �  6D    � ���� 5B     # �  6/    � ���� 5C     $ Arrow��6   # �  6<    � ��5D     5F     �� 5H     " ��6.   .R�5I  
   �� $ PART_ContentHost��6   |�.  #��z��6=   5J     �� 5L     " ��6&   .�5M  
   ��  �@J�SnapsToDevicePixels . 60   �� 5N  
    �@�OverridesDefaultStyle . 62   �� 5O  
    � ��$
 Auto=�6G   �� 5P  
    � ��$
 Auto=�6E   �� 5Q  
    � �� . 6:   �� 5R  
    � ��$	 120��6%   �� 5S  
    � ��$ 20��6&   �� 5T  
    � ��$ 15(�6%   �� 5U  
    � ��# �  6'   �� 5V  
    � �� 5W     �� 5X     " ��6"   .R�5Y     � .+�5Z     d� $��ToggleButton��5[     #��� & 5\     $��2��5]     |�.  $ Press=�5`      5_     �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5a     �� 5b     $��ContentSite��5c      .  #��z 5e     #��z 5f     #��z��5g     $��3,3,23,3q�5h     $��Center=�5i     $
��Left=�5j     �� 5k     $ PART_EditableTextBox��6"   8��  $
��Left=�5n     $��Center=�5o     $��3,3,23,3q�5p     |�. 
������ $y�Hidden=�5s     # z 5t     ��5l     Z� 5t     � 5u     $��Popup��5v     $��Bottom=�5w     #��z 5x      . |�.  $��Slide=�5{     .��5|     � $��DropDown��5}      . #��z 5     #��z 5�     .+�5�  "   �� $ DropDownBorder��5�     #���   5�     $��1q�5�     #���  5�     �� 5�  "   $��4,6,4,6q�6/    . .��5�  &   ��  . $ 	Contained=�6D   5�  #   5�     5�     5�      5�     P� 5�      �@��HasItems	 .  . �5�     �� $ DropDownBorder��6%    � ��$ 95��6V   5�     P� 5�      � {�	 .  . �5�     �� # �  6;    � ��5�     P� 5�      �@��
IsGrouping	 . . �5�     ��  � �� .  6N   5�     P� 5�     $  Popup��6"    �@�AllowsTransparency	 . . �5�     �� $ DropDownBorder��6%    �@��CornerRadius$ 4��6Y   �� 5�     $ DropDownBorder��6%    � ��$ 0,2,0,0q�6S   5�     P� 5�      �@��
IsEditable	 . . �5�     ��  � �� .  6:   �� 5�     $ PART_EditableTextBox��6%    � y�$ Visible=�6`   �� 5�     $ ContentSite��6%    � y�$ Hidden=�6T   5�     5�     5�     ! 5�  
   5�     �� 5�     " ��6(   .�5�  
   ��  �@J�SnapsToDevicePixels . 60   �� 5�  
    �@�OverridesDefaultStyle . 62   �� 5�  
    � |� .  6&   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� $��Border��5�     $��1q�5�     $ 2��5�     #���  5�     #���  5�     $��1q�5�     ._�5�     F� $��Center=�5�     $��Center=�5�     #���  5�     ��5�     �� $ Content� �� *TemplatedParent+5�      5�     P� 5�      � ��	 . . �5�     �� $ Border��6%   # �   6O    � ��5�     P� 5�      � {�	 .  . �5�     �� # �   6;    � ��5�     5�     5�     5�     �� 5�     " ��6(   .�5�  
   ��  �@J�SnapsToDevicePixels . 60   �� 5�  
    �@�OverridesDefaultStyle . 62   �� 5�  
    � �� .  6&   �� 5�  
    � |� .  6&   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� 
������ 6   5�     5�     5�     �� 5�     " n�6#   .�5�  
   ��  �@J�SnapsToDevicePixels . 60   �� 5�  
    �@�OverridesDefaultStyle . 62   �� 5�  
    � �� .  6&   �� 5�  
    � |� .  6&   �� 5�  
    � �� 5�     �� 5�     " n�6"   .R�5�     �� $ 2��5�     #��z��5�     #��z��5�     $��1q�5�     5�     5�     5�     �� 5�     " ��5�     .R�5�  
   � 
 5�     �� 5�     $��18��6    �� 5�     $��0.00001* �6    �� 5�     $��18��6    .+�5�     �� $��3��5�     $ 2��5�     #���  5�     �� 5�     $��0��5�     8��  $��18��5�     $��ScrollBar.LineUpCommand��5�     $��M 0 4 L 8 4 L 4 0 Z��5�     ]� 5�     $��
PART_Track��5�     $��1��5�     ��. " 5     �� 5     8�� $��ScrollBar.PageUpCommand��5     # 5     n� 5     8�� $��1,0,1,0q�5	     #���  5
     #���  5     $ 5     �� 5     8�� $��ScrollBar.PageDownCommand��5     5     �� 5     $��3��5     8�� $��18��5     $��ScrollBar.LineDownCommand��5     $��M 0 0 L 4 4 L 8 0 Z��5     5     5     �� 5     " ��62   .R�5  
   �  5     �� 5     $��18��6#   �� 5      $��0.00001* �6#   �� 5!     $��18��6#   .+�5#     �� $��3��5$     $ 2��5%     #���  5&     �� 5'     $��0��5(     8��  $��18��5*     $��ScrollBar.LineLeftCommand��5+     $��M 4 0 L 4 8 L 0 4 Z��5,     ]� 5-     $��
PART_Track��5.     $��1��5/     ��.  " 51     �� 52     8�� $��ScrollBar.PageLeftCommand��54     # 56     n� 57     8�� $��0,1,0,1q�59     #���  5:     #���  5;     $ 5=     �� 5>     8�� $ ��ScrollBar.PageRightCommand��5@     5B     �� 5C     $��3��5D     8�� $��18��5F     $ ��ScrollBar.LineRightCommand��5G     $��M 0 0 L 4 4 L 0 8 Z��5H     5I     5J     �� 5L     " ��6'   .�5M  
   ��  �@J�SnapsToDevicePixels . 60   �� 5N  
    �@�OverridesDefaultStyle . 62   ! 5O  
   P� 5P      �@��Orientation$	 
Horizontal=�6-   . �5Q     ��  � ��$
 Auto��6*   �� 5R      � ��$ 18��6+   �� 5S      � ��8   6-   5T     P� 5U      �@��Orientation$	 Vertical=�6-   . �5V     ��  � ��$ 18��6*   �� 5W      � ��$
 Auto��6+   �� 5X      � ��8  6-   5Y     5[     �� 5^     " ��6%   .�5_  
   ��  �@�OverridesDefaultStyle . 62   �� 5`  
    � �� 5a     �� 5b     " ��6"   .R�5c     �  5d     �� 5e     $
��Auto �6/   �� 5f     
 5h     �� 5i     �� 5j     $
��Auto �6,   .+�5m     �� $��1��61   �� 5o     $��PART_VerticalScrollBar��6$   #& z% 5p     #( z' 5q     #* z) 5r     #y�z+ 5s     �� 5t     $��PART_HorizontalScrollBar��6$   $, 
Horizontal=�5u     $��1��5v     $��1��5w     #& z- 5x     #( z. 5y     #* z/ 5z     #y�z0 5{     5|     5}     5     5�     �� 5�     " ��6   ! 5�  
   P� 5�      �@J�	IsFocused	 . . �5�     ��  � ��# �  6/   �� 5�      � ��# � 
 60   5�     P� 5�      � {�	 .  . �5�     ��  � ��# �   6/   5�     5�     �� 5�     " ��6   .�5�  
   ��  �@�OverridesDefaultStyle . 62   �� 5�  
    � ��$ 2q�6#   �� 5�  
    �@�Cursor$
 Hand��6#   �� 5�  
    � �� 5�     �� 5�     $	1 0,0&�6&   $	2 0,1&�67   .��5�     � $3 	#FFffc043��6#   $4 1Q�65   5�     5�     �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� $��border��6   $��1q�5�     $	5 4,2q�5�     
�������$ 3��5�     #��z��5�     ._�5�     � .+�5�     �� $��contentShadow��5�  <   $��Center=�5�  /   $��Center=�5�  !   #��� 0 5�  !   z�5�  "   T� 5�  &   $	6 1.0Q�69   $	7 1.0Q�6A   5�     �� 5�     $��content��5�  8   $��Center=�5�  /   $��Center=�5�     68   5�     5�      5�     P� 5�      �@J�IsMouseOver	 . . �5�     �� $ border��6%    � �� �	#FF4788c86P   �� 5�      � �� �	#FF3e3e426;   5�     P� 5�      � ��	 . . �5�     ��  � �� 5�  "   �� 5�  &   $	1 0,0&�6:   $	2 0,1&�6K   .��5�  *   � $3 	#FFFFDD9E��67   $4 1Q�6I   5�  '   5�     �� 5�     $ content��6%    � z� 5�  "   T� 5�  &   $	7 1.0Q�69   5�     5�     P� 5�      �@��IsDefaulted	 . . �5�     �� $ border��6%    � �� �	#FF2828286P   5�     P� 5�      �@J�	IsFocused	 . . �5�     �� $ border��6%    � �� �	#FFffab6c6P   �� 5�      � �� �	#FF3e3e426;   5�     P� 5�      � {�	 .  . �5�     �� $ border��6%    �@J�Opacity$	 0.7Q�6L   �� 5�      � ��
 �����6;   5�     5�     5�     5�     �� 5�     .�5�  
   ��  � ��
 �����6/   5�     �� 5�     .�5�  
   ��  � �� 5�     �� 5�     " ��6"   .R�5�     � $	��3 2q�6   .+�5�     �� $��r1��6$   $��1��6.   
���   �$	8 2 2R�6Q   �� 5�     $��border��6!   #��z 6/   #��z9 6U   $ 2��6~   $��1q�6�   5�     5�     5�     5�     5�     
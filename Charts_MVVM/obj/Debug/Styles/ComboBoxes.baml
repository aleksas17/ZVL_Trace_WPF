   M S B A M L   `   `   `  ����F  BCharts_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Charts_MVVMCharts_MVVM  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   ComboBoxToggleButton �� 
TargetType � ColumnDefinitions ��Name  BackgroundVeryLightBrush �� Source F�Name �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value  ForeGroundDarkBrush  ComboBoxTextBox  ComboBox_Style1 �� 
TargetType �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight J� Effect3   -System.Windows.Media.Effects.DropShadowEffect    
BlurRadius     ShadowDepth!    	Direction"    Color#    Opacity$ K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation%   DirectionalNavigation& P� 
SourceName' �� Padding�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:Charts_MVVM  5        5      �� 5   
   $ Colors.xaml?�6   %e  &	        7  7  7  7  7  &	 �    &	 �    7  7   7  '�� �    7  �� 5	      " d�63   .R�5   
   �  5      �� 5      �� 5      $��12 �6#   .+�5      �� $ Border��5      $��2��5      ���#cccedb$��1q�5      ��5      �� 8   5      �� 5      $ Border_Bacground��5      $��0��5      $��1q�5      $��0,0,1,0q�5       ��5      �� 8  ��5      �� 8  5       F� 5!      $ Arrow��5"      $��1��5#      ���#717171$��Center=�5%      $��Center=�5&      "����        ѐaT     �@* ��( 	5'      5)       5-   
   P� 5/       �@J�IsMouseOver	 . . �50      �� $
 Border��6    � �� �#c9def56C   �� 51      $
 Border��6    � �� �#007acc6D   �� 52      $
 Border_Bacground��6    � �� �#007acc6N   �� 53      $
 Arrow��6    6<   �� 8   � ��54      P� 56       �@d�	IsChecked$
	 trueY�68   . �57      �� $
 Border��6    � �� �#007acc6C   �� 58      $
 Border��6    � �� �#007acc6D   �� 59      $
 Border_Bacground��6    � �� �#007acc6N   �� 5:      $
 Arrow��6    6<   �� 8   � ��5;      5@      �� 5B      " ��6.   .R�5C   
   �� $ PART_ContentHost��6   |�.  #��z��6=   5D      �� 5H      " ��6$   .�5I   
   ��  �@J�SnapsToDevicePixels . 60   �� 5J   
    �@�OverridesDefaultStyle . 62   �� 5K   
    � ��$
 Auto=�6G   �� 5L   
    � ��$
 Auto=�6E   �� 5M   
    � �� . 6:   �� 5N   
    � ��$	 120��6%   �� 5O   
    � ��$ 20��6&   �� 5P   
    � �� 6'   �� 8   �� 5Q   
    � �� 5R      �� 5S      " ��6"   .R�5T      � .+�5V      d� $��ToggleButton��5W      8�� $��2��5Y      |�.  $ Press=�5\       5[      �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+5\      �� 5^      $��ContentSite��5_       .  #��z 5a      #��z 5b      #��z��5c      $��3,3,23,3q�5d      $��Center=�5e      $
��Left=�5f      �� 5h      $ PART_EditableTextBox��6"   8�� $
��Left=�5k      $��Center=�5l      $��3,3,23,3q�5m      |�. ���	#FF3F3F3F
��� � �$y�Hidden=�5q      # z 5r      ��5i      Z� 5r      � 5u      $��Popup��5v      $��Bottom=�5w      #��z 5x       . |�.  $��Slide=�5{      .��5}   "   � $��DropDown��5~   !    . #��z 5�   !   #��z 5�   !   $��0,0,8,8q�5�   !   .+�5�   &   �� $ DropDownBorder��5�   %   ���#f6f6f6$��1q�5�   %   ���#cccedb 5�   *      5�   .   $ 8Q�6?   $	  2.5Q�6N   $	! 315Q�6`   $" #BBBBBB��6p   $	# 0.2Q�6�   5�   '   �� 5�   &   $��3,0,3,0q�63    . .��5�   *   �� $ . $% 	Contained=�6H   5�   '   5�   #   5�      5�       5�      P� 5�       �@��HasItems	 .  . �5�      �� $
 DropDownBorder��6%    � ��$ 95��6V   5�      P� 5�       � {�	 .  . �5�      ��  � �� �#8888886;   5�      P� 5�       �@��
IsGrouping	 . . �5�      ��  � �� .  6N   5�      P� 5�      $& Popup��6"    �@�AllowsTransparency	 . . �5�      �� $
 DropDownBorder��6%    �@��CornerRadius$ 0��6Y   �� 5�      $
 DropDownBorder��6%    � ��$ 0q�6S   5�      P� 5�       �@��
IsEditable	 . . �5�      ��  � �� .  6:   �� 5�      $
 PART_EditableTextBox��6%    � y�$ Visible=�6]   �� 5�      $
 ContentSite��6%    � y�$ Hidden=�6T   5�      5�      5�      5�      �� 5�      " ��6*   .�5�   
   ��  �@J�SnapsToDevicePixels . 60   �� 5�   
    � �� 6'   �� 8   �� 5�   
    �@�OverridesDefaultStyle . 62   �� 5�   
    � �� 5�      �� 5�      " ��6"   .R�5�      �� $��Border��6   $' 2q�5�       . ._�5�      �� 5�       5�      P� 5�       �@��IsHighlighted	 . . �5�      �� $
 Border��6%    � �� �#c9def56O   5�      P� 5�       � {�	 .  . �5�      ��  � �� �#8888886;   5�      5�      5�      5�      5�      
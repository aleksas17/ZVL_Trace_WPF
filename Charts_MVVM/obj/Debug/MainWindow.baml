   M S B A M L   `   `   `  ����F  BCharts_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Charts_MVVMCharts_MVVM  5   	       Charts_MVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Charts_MVVM     5   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ 
MainWindow��5   	   $	��700��6   $
��1000��6)   ��5   	   �� *WindowMinimumHeight+��5	   	   �� *WindowMinimumWidth+.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   
����������	#FFDADBDC���	#FF212121$��0,0,0,1q�6^   .@�5      m� $
��File��6   $��	19,3,19,3q�6%   $��2,0,2,0q�69   .@�5      m� $��Open...��6    m� Command 6,   �� *SelectDirectory+6R   m� 5      $
��Exit��6   6+   5      m� 5      $
��Edit��6   $��	19,3,19,3q�6%   $��2,0,2,0q�69   6L   m� 5      $
��Help��6   $��	19,3,19,3q�6%   $��2,0,2,0q�69   6L   5       � 5   
   -   5          �Name$ 	MainFrame��5      $��1��6   ��60   �� *CurrentPage+ �� 	Converter /   )Charts_MVVM.ApplicationPageValueConverter  5      5      
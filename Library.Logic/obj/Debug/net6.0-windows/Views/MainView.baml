   M S B A M L   `   `   `  ����H  DLibrary.Logic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Library.Logic.ViewsLibrary.Logic.Views  5   	   C&clr-namespace:Library.Logic.ViewModelsLibrary.Logic.ViewModels  5   	   "    Library.Logic.Views.MainView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Library.Logic.Views     5   	   <	viewmodel&clr-namespace:Library.Logic.ViewModels     5   	     � Title$  MainView��5
   	    � WindowState$ 	Maximized=�6   $
��1080��62   $
��1920��6@    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   �� 5      $d ^pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Menu.xaml?�6%   �� 5      $g apack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.ToolTip.xaml?�6%   %    5      .��5      �  � ColumnDefinitions 5   
   �� 5      -   5         �Name$
 col1��5      ��6+   �� *	Col1width+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6}   �� 5      -   5        $
 col2��5      ��6+   �� *	Col2width+$ PropertyChanged=�$ TwoWay=�6|   .+�5   
   �� 
����ح�$	��640��6,   $
��1080��68   $��Center=�6F   $��Center=�6c   .+�5      �� $��Center=�6   $	��120(�61   $��Italic$�6@   $
��Bold"�6S   
����� �.��6~   Login6�   �� 5      $��Center=�6   $��60(�61   
����d�$��0,80,0,0q�6[   .��6m   
Username6w   �� 5      
����d�$��60(�62   $	��420��6@   ��6L   �� *
Username+$ PropertyChanged=�$ TwoWay=�6�   �� 5      $��Center=�6   $��60(�61   
����d�$��0,80,0,0q�6[   .��6m   
Password6w   �� 5      
����d�$��60(�62   $	��420��6@   ��6L   �� *
Password+$ PropertyChanged=�$ TwoWay=�6�   �� 5      $��
0,100,0,10q�6   $	��100��6)   $	��300��66   $��40(�6B   $��	ExtraBold"�6P   ��6g   �� *loginCommand+.��6�   Login6�   �� 5       $��	0,20,0,10q�6   $	��100��6(   $	��300��65   $��40(�6A   $��	ExtraBold"�6O   ��6f   �� *registerViewCommand+.��6�   Registration6�   5!      �� 5"   
   $��1��6   ��6)   �� *CurrentViewModel+6P   5#      5$      
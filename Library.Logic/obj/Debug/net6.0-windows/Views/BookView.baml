   M S B A M L   `   `   `  ����H  DLibrary.Logic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Library.Logic.ViewsLibrary.Logic.Views  5      C&clr-namespace:Library.Logic.ViewModelsLibrary.Logic.ViewModels  5      "    Library.Logic.Views.BookView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Library.Logic.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      6	viewmodel&clr-namespace:Library.Logic.ViewModels  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Minteracitivy:http://schemas.microsoft.com/expression/2010/interactivity  5	      
�������.��5      �   � RowDefinitions  5   
   �� 5      6   �� 5      $	��12* �6   6+   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6/   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Standard=�5      $��8 4 8 4q�5         CornerRadius$ 2��5       K� ZIndex$ 1��5      $��16 0 0 0q�5      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5      .��5      �  � ColumnDefinitions 5      �� 5      $
��Auto �5      �� 5       $��* �5!      �� 5"      $
��Auto �5#      .+�5%      �� $��1��5&      $��8 0 0 0q�5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5(      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5)      $��0q�5*      $	��200��5+      $��Center=�5-      ��5,      �� *Txtb_search+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�.��5-   4   .  (System.Windows.Interactivity.Interaction   Triggers 5.      /  )System.Windows.Interactivity.EventTrigger  5/         	EventName$ TextChanged��68   .  (System.Windows.Interactivity.TriggerBase   Actions. 50   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6C   �� *TextchangedCommand+52   #   53      .��54   =   55      56      57      �� 58       &  "MaterialDesignToolForegroundButton#��[  59      $��8 0 0 0q�5:      $ 0��5;      ��5<      �� *Historycommand+.��5=      '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ History=�5>      5?      �� 5@      #��[  5A      $��8 0 0 0q�5B      $ 0��5C      ��5D      �� *
AllCommand+.��5E      	  $ 	BorderAll=�5F      5G      5H      &
   System.Windows.Controls.DataGrid
  5I   
   $��1��6   $��False��6    $��0,0,0,0q�6F    
  AutoGenerateColumns$ False��6�    
  
IsReadOnly$
 True��6�   ��6W   �� *Books+$	 PropertyChanged=�$
 TwoWay=� �� SelectedItem 6�   �� *SelectedBook+$	 PropertyChanged=�$
 TwoWay=� 
  Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6%      Header$ 	Book Name��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Name+  5L      $	 200 6&   $ 
Page Count��62    6F   �� *Pages+  5M      $	 200 6%   $ Comment��61    6B   �� *	Comment+  5N      $	 200 6%   $ Quantity��61    6C   �� *
Quantity+4  .System.Windows.Controls.DataGridTemplateColumn  5O         CellTemplate 5P      �� 5Q      .R�5R      �� $ 
Horizontal=�6)   .+�5S   "   �� $
��Take��69   $
��Take��6*   ��5T   *   ��  �� Path$" DataContext.ClickTakeCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType" 
 ��6�   �� 5U      5V         HeaderTemplate 5X      �� 5Y      .R�5Z      �� $��Action��6(   5[      5]      5_      5`      5a      
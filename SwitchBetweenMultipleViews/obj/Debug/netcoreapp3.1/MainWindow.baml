   M S B A M L   `   `   `  ����U  QSwitchBetweenMultipleViews, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SwitchBetweenMultipleViewsSwitchBetweenMultipleViews  5   	   +    %SwitchBetweenMultipleViews.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:SwitchBetweenMultipleViews     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� ��6   �� *SelectedViewModel+�� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� $��10q�6   $	��160��6!   $
��Home��6-   $
��Home��6b   ��6<   �� *UpdateViewCommand+6b   �� 5      $��10q�6   $	��160��6!   $��Account��6-   $��Account��6e   ��6?   �� *UpdateViewCommand+6e   �� 5      $��10q�6   $	��160��6!   $
��Menu��6-   $
��Menu��6b   ��6<   �� *UpdateViewCommand+6b   5      5      5      
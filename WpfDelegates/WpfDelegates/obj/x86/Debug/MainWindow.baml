   M S B A M L   `   `   `  ����  WpfDelegates    WpfDelegates.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $	��53* �6   �� 5      $
��265* �6   �� 5	      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      .+�5      �� $��0��6   $��10q�6&   $��30��62   �� 5      -   5         ��Name$ 	BtnSearch��5      $��1��6(   $��10q�68   $��30��6D   $��Buscar��6P   6a   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGListPerson��5      $��1��6)   $��10q�66      AutoGenerateColumns .   � DataContext 5      �� ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� 
 �� Path$

 Name�  5      $ Apellido��6%   	 67   �� $
 LastnameDad�  5      $ Telefono��6%   	 67   �� $
 	Telephone�  5      $ Celular��6%   	 66   �� $
 Celular�  5      $ 	Direccion��6%   	 68   �� $
 Address�  5      $ correo��6%   	 65   �� $
 Correo�4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5       �� 5!      .R�5"      �� -   5        $��Editar��5"   %   66   5#      5%        5(       5)      �� 5*      .R�5+      �� -   5        $	��Mas��5+   %   63   5,      5.      50      � 51   
   $��2��6    52      �� 53      $��2* �6#   �� 54      �� 55      58      5:      5<      
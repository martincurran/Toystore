   M S B A M L   `   `   `  ����@  <Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdminAdmin  5   	       Admin.ProductWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %Adminclr-namespace:Admin     5   	     � Title$  Product Window��5   	   $	��600��6    $	��825��6-    � DataContext 5	        Admin.ViewModel  5
   
   .��5      � $��	0,0,0,-77q�6    � RowDefinitions 5   
   �� 5      $
��170* �6   �� 5      $
��103* �6   .+�5   
   �� $��2��6   $��
10,0,-10,0q�6&   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5      $
��Left=�6)   $��	22,38,0,0q�6D   $	��Top=�5      $	��309��6+   $	��785��68      AutoGenerateColumns .  ��5   /   �� *ProductList+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedProduct+$ TwoWay=�$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6I   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *ProductName+6I     5      $	 Price��6D   
 6)   �� *Price+6D     5      $	 Image��6q   
 6)   �� *	mageUrl+$ TwoWay=�$ 	LostFocus=�6q     5      $	 Description��6I   
 6)   �� *Description+6I   5      �� 5      -   5         ��Name$ btnSave��5      $
��Save��6&   $
��Left=�65   $	��Top=�6Q   $��75��6i   $��60,10,10,10q�6�   $��30��6�   �� 5       �� Orientation$ 
Horizontal=�6   .+�5       �� $��60,0,0,0q�6   $
��Left=�6/   $��Center=�5!      .+�5"      �� -   5         ��Name$ edtProdcutName��5"      $
��Left=�66   $��23��6Q    �� TextWrapping$
 Wrap=�5#      $	��Top=�5%      $	��206��5&      $	��0,4q�6F   ��5$      �� *ProductName+ 5&      �� *SelectedProduct+6F   �� 5'      -   5        $ textBox_Copy��5'      $
��Left=�64   $��23��6O   $
 Wrap=�5(      $	��Top=�5*      $	��206��5+      $	��0,4q�6A   ��5)      �� *Price+ 5+      �� *SelectedProduct+6A   �� 5,      -   5        $ textBox_Copy1��5,      $
��Left=�65   $��23��6P   $
 Wrap=�5-      $	��Top=�5/      $	��206��50      
��� � �$	��0,4q�6T   ��5.      �� *Description+ 50      �� *SelectedProduct+6T   51      �� 52      $	��200��6   $	��140��6$   $��10,0,0,0q�61   ��6C   �� *SelectedProduct.mageUrl+ J� Effect 53      3  -System.Windows.Media.Effects.DropShadowEffect  54      56      �� 57      $ Vertical=�6   .+�58      �� -   5        $ btnSelectImge��58      $��30��64   $	��150��6@   $��Select Image��6L   $��10q�6c   6o   �� 59      -   5        $ btnUploadBlob��59      $��30��64   $	��150��6@   $��Upload Image��6L   $��10q�6c   6o   �� 5:      -   5         ��Name$ 
fileSource��5:      $	��300��60   $	��TBD��6<   �� 5;      -	   5        $ BlobUri��5;      $	��TBD��6-   5<      5=      5>      5?      5@      
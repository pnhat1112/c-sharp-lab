   M S B A M L   `   `   `  ����C  ?MyWDPApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MyWDPAppMyWDPApp  5   	   "    MyWDPApp.ManageCategoriesApp   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MyWDPApp     5   	   -   5          � Title$  ManageCategoriesApp��5   	   $	��450��6%   $	��419��62    � WindowStartupLocation$ CenterScreen=�6U   .��5	      ]� $	��Top=�6   $��10q�6(   .+�5
   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      �� 
����ح� �� Orientation$ Vertical=�60   $
��Left=�5      $	��400��64   .+�5      �� -   5        $��lblInstruction��5      
���  ��$��DemiBold"�6?   $��20(�5      $��Category Information��6"   �� 5      -   5        $��lblCategoryID��5      $��
CategoryID��6-   �� 5      -   5        $��txtCategoryID��5      $
��Left=�6/    �� 
IsReadOnly$
 True��5      $��25��6(   $	��300��64   ��6@   ��  �� Path$ 
CategoryID� �� Mode$ OneWay=� � DataContext 6n   ��  �� ElementName$ lvCategories��$ SelectedItem��� 5      -   5        $��lbCategoryName��5      $��Category Name��6.   �� 5      -   5        $��txtCategoryName��5      $
��Left=�61   $��25��5      $	��300��6"   ��6.   �� $ CategoryName�$ OneWay=� 6^   �� $ lvCategories��$ SelectedItem��� 5      $ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5        	 ��Name$	 	btnInsert��5      $��10q�60   $��80��6<   $��Insert��6G   5      �� 5      -   5        $	 	btnUpdate��5      $��10q�61   $��80��6=   $��Update��6I   5      �� 5      -	   5        $	 	btnDelete��5      $��10q�60   $��80��6=   $��Delete��6H   5       5!      5"      �� 5#      -
   5        $��lvCategories��5#   $   $��1��6   $	��400��68   
 �� View
 5$      �� 5%      .P�5&      �� $��Category ID��6)    �� Width$	 100��6?    �� DisplayMemberBinding 5'   %   �� $ 
CategoryID��� 5(      $��Category Name��6)   $	 200��6@    5)   %   �� $ CategoryName�5*      5,      5.      5/      50      
   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5      !    ExpenseIt.ExpenseReportPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5        N� Title$  ExpenseIt - View Expense��5	      .��5      �  � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @ExpenseAmount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5       $
��Auto �6   �� 5!      .+�5#   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Expense Report For:5$      � 5%   
   $��10q�6   $��1��6   $��1��6+    5&      �� 5'      �� 5(       5*      �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      .+�51      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6K   .+�52      ��   
labelStyle#��[ 6   .��6<   Name:6C   �� 53      #��[ 6   ��6<   �� $ @Name��6_   54      �� 56      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6K   .+�57      �� #��[ 6   .��6<   Department:6I   �� 58      #��[ 6   ��6<   �� $ @Department��6e   59      � 5:      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\   .+�5<      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6A      AutoGenerateColumns$ False��6x   	   RowHeaderWidth$	 0Q�6�   ��6   �� $ Expense��
   Columns
 5=      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� $ @ExpenseType��  5?      $ Amount��6-    6=   �� $ @ExpenseAmount��5A      5B      5C      5D      5E      
   M S B A M L   `   `   `  ����  Control2_Den    LibrarySystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$-  'Библиотечная система��5   	   $	��600��6&   $	��800��63   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $��Пользователь:��6   $��0,0,5,0q�6-   �� 5      -   5         ��Name$ CurrentUserTextBlock��5      $
��Bold"�66   �� 5      -   5        $!��Добавить книгу��5      $��10,0,0,0q�6.   6@   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BooksDataGrid��5       $��1��6   $��10q�67      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .    SelectionMode$ Single=�5   <   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Артикул��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *ArticleNumber+6X     5      $
 Название��6%   $ * 6Q    67   �� *Title+6Q     5      $
 Жанр��6%   $	 120 6M    63   �� *Genre+6M     5      $
 Дата выпуска��6%   $	 100 6z    6;   �� *ReleaseDate+ �� StringFormat$ {0:dd.MM.yyyy}��6z     5      $
 Статус��6%   $	 120 6P    65   �� *Status+6P     5      $
 Читатель��6%   $	 150 6b    67   �� *CurrentReader.FullName+6b   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Auto 6)      CellTemplate 5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��Выдать��5   )   $��2q�6:   {�5    )   �� *Status+   StatusToBoolConverter �� 	Converter# [   �� ConverterParameter$ 	Available���� 5!   "   -   5        $��Вернуть��5!   )   $��2q�6;   {�5"   )   �� *Status+# [  $ Issued���� 5#   "   -   5        $��Обслуживание��5#   )   $��2q�6@   {�5$   )   �� *Status+# [  $ 	Available���� 5%   "   -   5        $ ��Редактировать��5%   )   $��2q�6A   6L   �� 5&   "   -   5        $��Удалить��5&   )   $��2q�6;   6F   5'      5(      5*      5,      5-      5.      
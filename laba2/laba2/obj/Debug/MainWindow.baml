   M S B A M L   `   `   `  ����	  laba2+    %UniversityManagementSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$"  University Management System��5   	   $	��350��6.   $	��525��6;   .��5      ]� .+�5   
   �� $	��Top=�6    �� Orientation$ 
Horizontal=�6*   $��10q�6C   .+�5      �� $	��Top=�6   $ 
Horizontal=�6.   $��10q�6G   .+�5      �� -   5        $��Add Student��5      $��0,0,10,0q�6N   �� 5	      -   5        $��Edit Student��5	      $��0,0,10,0q�6P   �� 5
      -   5        $��View Applications��5
      $��0,0,10,0q�6Z   �� 5      -   5        $��Assign Responsible��5      66   �� 5      -   5        $��View Statistics��5      63   5      5      �� 5   
   -   5         ��Name$ StudentsListView��5      $��10q�6-    �� View 5      �� 5      .P�5      �� $��
First Name��6%    �� DisplayMemberBinding 69   �� *	FirstName+�� 5      $��	Last Name��6%    68   �� *
LastName+�� 5      $	��Age��6%    62   �� *Age+�� 5      $��Email��6%    64   �� *Email+5      5      �� 5   
   -   5        $ CoursesListView��5      $��10q�6,    5      �� 5      .P�5      �� $��Course Name��6%    6:   �� *Name+�� 5      $��
Instructor��6%    69   �� *
Instructor+�� 5      $��Schedule��6%    67   �� *
Schedule+�� 5      $��Students��6%    67   �� *Students.Count+5       5"      5#      5$      
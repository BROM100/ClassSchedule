   M S B A M L   `   `   `  ����H  DClassSchedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClassScheduleClassSchedule  5   	       ClassSchedule.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ClassSchedule     5   	     � Title$  Class Schedule��5   	   $	��450��6    $	��700��6-   $	��450��69   $	��450��6I   $	��700��6Y   $	��700��6h   .��5	      � .+�5   
   �� -   5        $��ItemList��5      $��5,20,5,0q�6#   $	��195��65   $	��690��6B   $	��Top=�6N   $
��Left=�6f    �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 30��61    �� DisplayMemberBinding 6=   �� *
Class_id+�� 5      $��Classes��6%   $	 200��66    6C   �� *
Class_name+�� 5      $��Student Name��6%   $	 150��6;    6G   �� *Student_name+�� 5      $��Teacher Name��6%   $	 150��6;    6G   �� *Teacher_name+�� 5      $��	Room Name��6%   $	 150��68    6D   �� *	Room_name+5      5      �� 5   
   -   5         ��Name$ EnableCheckBox��5      $
��Edit��6+   $
��Left=�6;   $��
10,230,0,0q�6V   $	��Top=�6j   � 5   
   -   5         �Name$ EditGrid��5      $��	3,260,0,0q�6a   $��Stretch=�6u   $	��Top=�6�   {�6!   ��  �� ElementName$ EnableCheckBox�� �� Path$ 	IsChecked�.+�5      �� $��Student Name��6   $
��Left=�6+   $��3,0,0,0q�6F   $	��Top=�6Y   �� 5      $��Teacher Name��6   $
��Left=�6+   $��3,40,0,0q�6F   $	��Top=�6X   �� 5      $��	Room Name��6   $
��Left=�6(   $��	300,0,0,0q�6C   $	��Top=�6V   �� 5      $��Classes Name��6   $
��Left=�6+   $��
300,40,0,0q�6F   $	��Top=�6Z   �� 5      -   5        $��StudentTextBox��5      $
��Left=�6~   $��95,0,0,0q�6�   $	��150��6�   $��26��6�   $	��Top=�6�   ��6,   �� $ ItemList��$ SelectedItem.Student_name� �� Mode$ OneWay=�6�   �� 5       -   5        $��TeacherTextBox��5       $
��Left=�6~   $��	95,40,0,0q�6�   $	��150��6�   $��26��6�   $	��Top=�6�   ��6,   �� $ ItemList��$ SelectedItem.Teacher_name�$ OneWay=�6�   �� 5!      -   5        $��RoomTextBox��5!      $
��Left=�6x   $��	390,0,0,0q�6�   $	��150��6�   $��26��6�   $	��Top=�6�   ��6)   �� $ ItemList��$ SelectedItem.Room_name�$ OneWay=�6�   �� 5"      -   5        $��ClassesTextBox��5"      $
��Left=�6|   $��
390,40,0,0q�6�   $	��150��6�   $��26��6�   $	��Top=�6�   ��6,   �� $ ItemList��$ SelectedItem.Class_name�$ OneWay=�6�   5#      �� 5%   
   -   5        	 ��Name$	 CreateButton��5%      $
��Left=�6g   $��
10,360,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��5&      �� 
 �� Orientation$
 
Horizontal=�6   .+�5'      �� $��Create��6   5(      5)      �� 5,   
   -	   5        $	 UpdateButton��5,      $
��Left=�6g   $��
90,360,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��5-      �� $
 
Horizontal=�6   .+�5.      �� $��Update��6   5/      50      �� 52   
   -
   5        $	 DeleteButton��52      $
��Left=�6g   $��170,360,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��53      �� $
 
Horizontal=�6   .+�54      �� $��Delete��6   55      56      �� 58   
   -   5        $	 BacktologinButton��58      $
��Left=�6-   $��370,360,0,0q�6H   $	��Top=�6w   $��70��6�   .��59      �� $
 
Horizontal=�6   .+�5:      �� $��Sign Out��6   5;      5<      �� 5>   
   -   5        $	 ManageUsersButton��5>      $
��Left=�6-   $��450,360,0,0q�6H   $	��Top=�6w   $	��100��6�   .��5?      �� $
 
Horizontal=�6   .+�5@      �� $��Manage Users��6   5A      5B      5I      5J      
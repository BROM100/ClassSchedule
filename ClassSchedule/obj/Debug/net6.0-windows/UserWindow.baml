   M S B A M L   `   `   `  ����H  DClassSchedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClassScheduleClassSchedule  5   	       ClassSchedule.UserWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ClassSchedule     5   	     � Title$  
UserWindow��5   	   $	��460��6   $	��310��6)   $	��460��65   $	��460��6E   $	��310��6U   $	��310��6d   .��5	      � .+�5
   
   �� -   5        $��UserList��5
      $��5,20,5,0q�6#   $	��195��65   $	��300��6B   $	��Top=�6N   $
��Left=�6f    �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 30��61    �� DisplayMemberBinding 6=   �� *ID+�� 5      $��Username��6%   $	 110��67    6D   �� *
Username+�� 5      $��Password��6%   $	 150��67    6C   �� *
Password+5      5      �� 5   
   -   5         ��Name$ EnableCheckBox��5      $
��Edit��6+   $
��Left=�6;   $��	7,225,0,0q�6V   $	��Top=�6i   � 5   
   -   5         �Name$ EditGrid��5      $��	3,300,0,0q�6!   $��Stretch=�65   $	��Top=�6S   .+�5      �� $��Username��6   $
��Left=�6+   $��3,0,0,0q�6F   $	��Top=�6Y   �� 5      $��Password��6   $
��Left=�6+   $��3,40,0,0q�6F   $	��Top=�6X   �� 5      -   5        $��UsernameTextBox��5      $
��Left=�6   $��87,0,0,0q�6�   $	��150��6�   $��27��6�   $	��Top=�6�   ��61   ��  �� ElementName$ UserList�� �� Path$ SelectedItem.Username� �� Mode$ OneWay=�6�   �� 5      -   5        $��PasswordTextBox��5      $
��Left=�6   $��	87,40,0,0q�6�   $	��150��6�   $��27��6�   $	��Top=�6�   ��61   �� $ UserList��$ SelectedItem.Password�$ OneWay=�6�   5      �� 5   
   -   5        	 ��Name$	 CreateButton��5      $
��Left=�6g   $��
35,250,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��5      �� 
 �� Orientation$
 
Horizontal=�6   .+�5       �� $��Create��6   5!      5"      �� 5%   
   -   5        $	 UpdateButton��5%      $
��Left=�6g   $��115,250,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��5&      �� $
 
Horizontal=�6   .+�5'      �� $��Update��6   5(      5)      �� 5+   
   -   5        $	 DeleteButton��5+      $
��Left=�6h   $��195,250,0,0q�6�   $	��Top=�6�   $��70��6�   {�6'   �� $ EnableCheckBox��$ 	IsChecked�.��5,      �� $
 
Horizontal=�6   .+�5-      �� $��Delete��6   5.      5/      �� 51   
   -	   5        $	 BacktoMainPageButton��51      $
��Left=�60   $��
90,385,0,0q�6h   $	��Top=�6|   $	��150��6�   .��52      �� $
 
Horizontal=�6   .+�53      �� $��Back to Main Window��6   54      55      59      5:      
   M S B A M L   `   `   `  ����L  HBuddyOrganizer.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BuddyOrganizer.UIBuddyOrganizer.UI  5   	   "    BuddyOrganizer.UI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BuddyOrganizer.UI     5   	     � Title$  BuddyOrganizer��5   	   $	��450��6    $	��800��6-   $��20(�69   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��200 �6   �� 5      .+�5   
   ��  �� DisplayMemberPath$ 	FirstName��5      ��5      �� *	Buddies+ �� SelectedItem 5      �� *SelectedBuddy+ �� Mode$ TwoWay=�5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      .+�5      �� $��	Firstname��6   $��
10 10 10 0q�6(   �� 5      $��1��6   $��
10 0 10 10q�5   @   ��5   #   �� *SelectedBuddy.FirstName+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5   @   �� 5      $��2��6   $��Lastname��6!   $
��10 0q�64   �� 5       $��3��6   $��
10 0 10 10q�5!   @   ��5    #   �� *SelectedBuddy.LastName+$ TwoWay=�$ PropertyChanged=�5!   @   �� 5#      $��4��6   $��Email��6!   $
��10 0q�61   �� 5$      $��5��6   $��
10 0 10 10q�5%   @   ��5$   #   �� *SelectedBuddy.Email+$ TwoWay=�$ PropertyChanged=�5%   @   5&      5'      5(      
   M S B A M L   `   `   `  ����B  >BookApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookAppBookApp  5   	       BookApp.BookWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BookApp     5   	   -   5          � Title$  Add/Modify A Book Info��5   	   $��382.667��6(   $	��500��69   
����İ� +� FocusedElement 5	   	   ��  �� ElementName$ uxName��.��5      � -   5         �Name$ uxGrid��5      $��0,0,0.333,2.333q�6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��22 �6   �� 5      $��26.667 �6   �� 5      $
��auto �6   $��28.667��6*   �� 5      $
��auto �6   $��226.667��6*   �� 5      $
��auto �6   $��137.333��6*   .+�5   
   �� $��0��6   $��0��6$   $
��Left=�61   $��10,3,0,0q�6L   $	��107��6^   $��2��6j   $��19��6~   $	��Top=�6�   Book Title:6�   �� 5   
   -   5         ��Name$ uxTitle��5      $��0��6:   $��38.667,0,71.333,1q�6G   $��1��5      ��5   #   �� *Title+5      �� 5   
   $��0��6   $��1��6$   $
��Left=�61   $��10,6,0,2.667q�6L   $	��107��6b   $��2��6n   Book Category:6�   �� 5   
   -   5        $ 
uxCategory��5      $��1��6@   $��38.667,2,71.333,0.667q�6M   $��1��5       J� RenderTransformOrigin$ 0.5,0.5&�6"   ��5   &   �� *
Category+.��5   B   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ -0.174Q�6&   T� 5%      5&      .��5'   '   5(      �� 5*   
   $��2��6   $
��Left=�6!   $��10,7.333,0,0.333q�6<   $��99��6V   $��2��6a   Price:6}   �� 5+   
   -   5        $ uxPrice��5+      $��2��6:   $ ��38.667,5.333,313.333,0.333q�6G   $��1��5,      $ 0.413,-2.609&�6"   ��5+   #   �� *Price+5,   "   �� 5.   
   $��2��6   $
��Left=�6!   $��236.667,7.333,0,0.333q�6<   $��42��6[   $��1��6f   Cost:6}   �� 5/   
   -   5        $ uxCost��5/      $��2��68   $ ��284.667,5.333,71.333,0.333q�6E   $��1��50      ��5/   "   �� *Cost+50      �� 52   
   $��0��6   $��3��6$   $
��Left=�61   $��10,61.667,0,146q�6L   $	��107��6e   $��2��6q   Author First Name:6�   �� 53   
   -   5        $ uxFName��53      $��3��6:   $��38.667,57.667,254.333,146q�6G   $��1��54      ��53   #   �� *FName+54      �� 56   
   $��1��6   $��3��6$   $
��Left=�61   $��179.667,60.667,0,147q�6L   $��99��6j   Author Last Name:6�   �� 57   
   -   5        $ uxLName��57      $��3��6:   $��283.667,57.667,10.333,146q�6G   $��1��58      ��57   #   �� *LName+58      �� 5:   
   $��3��6   $
��Left=�6!   $��10,4.667,0,201q�6<   $��99��6T   $��2��6_   
ISBN-10:6}   �� 5;   
   -	   5        $ 	uxISBN_10��5;      $��3��6>   $��38.667,4.667,254.333,199q�6K   $��1��5<      ��5;   %   �� *	ISBN_10+5<      �� 5>   
   $��3��6   $
��Left=�6!   $��236.667,6.667,0,199q�6<   $��42��6Y   $��1��6d   
ISBN-13:6~   �� 5?   
   -
   5        $ 	uxISBN_13��5?      $��3��6>   $��283.667,4.667,10.333,199q�6K   $��1��6m   ��6%   �� *	ISBN_13+6m   �� 5A   
   $��3��6   $
��Left=�6!   $��10,32.667,0,173q�6<   $��99��6U   $��2��6`   	Quantity:6   �� 5B   
   -   5        $ uxQty��5B      $��3��6;   $��38.667,32.667,313.333,171q�6H   $��1��5C      ��5B   !   �� *
Quantity+5C      �� 5E   
   $��0��6   $��4��6$   $��Right=�61   $��0,7,0.333,104.333q�6M   $��83��6h   6u   �� 5F   
   $��3��6   $
��Left=�6!   $��10,107.667,0,98q�6<   $��99��6U   $��2��6`   Phone:6|   �� 5G   
   -   5        $ uxPhone��5G      $��3��6:   $��38.667,107.667,254.333,96q�6G   $��1��5H      ��5G   #   �� *Phone+5H      �� 5J   
   $��3��6   $
��Left=�6!   $��10,133.667,0,72q�6<   $��42��6U   Notes:6h   �� 5K   
   -   5        $ uxNotes��5K      $��3��6:   	 �� AcceptsReturn	 . 
 �� TextWrapping$

 Wrap=�5L      $��38.667,134.667,10.333,51q�6&   $��1��6H   ��5K   #   �� *Notes+5L   H   �� 5N   
   $��3��6   $
��Left=�6!   $��236.667,109.667,0,96q�6<   $��42��6Z   $��1��6e   Email:6}   �� 5O   
   -   5        $ uxEmail��5O      $��3��6:   $��283.667,107.667,10.333,96q�6G   $��1��5P      ��5O   #   �� *Email+5P      �� 5R   
   $��0��6   $��3��6$   $
��Left=�61   $��10,85.667,0,122q�6L   $	��107��6e   $��2��6q   Author Birthdate:6�   �� 5S   
   -   5        $ uxBirthDate��5S      $��3��6B   $��38.667,81.667,254.333,122q�6O   $��1��6r   ��6'   �� *	Birthdate+6r   �� 5V   
   -   5         ��Name$ uxSubmit��5V      
��� ���$$��43.667,186.667,216.333,136.333q�5W   '   $��
Add/Modify��5X      $��1��6*   $��3��6:   $��2��6G   �� 5Y   
   -   5        $ uxCancel��5Y      
��� ���$$��212.667,186.667,47.333,136.333q�5Z   '   $��Cancel��6O   $��1��5[      $��3��6"   $��2��6/   5b      5c      
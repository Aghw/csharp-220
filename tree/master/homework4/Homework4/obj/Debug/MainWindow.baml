   M S B A M L   `   `   `  ����D  @Homework4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Homework4	Homework4  5   	       Homework4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Homework4     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   
��� ���.��5
   
   � .+�5      �� -   5         ��Name$ uxMenuAndUIControllers��5      .+�5      o� 
���2͚�.@�5      m� $��_File��6   
�������.@�5      m� -   5        $
��_New��5   #    m� Icon 5      �� 5   "   $��images/new-menu-item.png��6(   5      m� 5      $��_Open��6#   �� 5      m� 5      -   5        $��E_xit��5   #   62   5      m� 5      $��_Edit��6   .@�5      m� -   5        $��_Undo��5   #   62   m� 5      $��_Select All��6#   �� 5      m� 5      $��E_xit��6#   5      m� 5      $��_Help��6   5      5      `� 5!       `� 
Background
 �����.�5"      c� .@�5#      �� -   5        $	��New��5#   !   6/   �� 5$      $
��Copy��6!   �� 5%      $��Paste��6!   �� 5&      -   5        $��Close��5&   !   61   5'      c� 5(      .@�5)      �� .��6    
Font size:6,   �� 5*      .@�5+      �� .��6+   106/   �� 5,       �� 
IsSelected . .��6=   126A   �� 5-      .��6+   146/   �� 5.      .��6+   166/   5/      50      51      �� 54      $��	68,20,0,0q�6    Enter Zip Code or Postal Code:6O   �� 56      -   5         ��Name$ uxZpcode��56      $	��150��57      $��25��6!   
�������$
��16px(�6A   $��Impact)�6Q   
����  ���58      �� *ZpCode+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . .��59   3   5:      �� 5<      -   5         ��Name$ uxZpcodeError��5<      $��26��5=   W   
����·�$��0,2,-0.333,0q�5>   2   ��5=      �� *ZipCodeError+$ PropertyChanged=�5>   J   �� 5@      -	   5        	 ��Name$	 uxSubmit��5@      ���	#FF4EBCDF$	��150��5A   ,   $��40��68   $��0,10,0,0q�6D   $��Submit��6V   {�.  6g   5C      5D      5E      
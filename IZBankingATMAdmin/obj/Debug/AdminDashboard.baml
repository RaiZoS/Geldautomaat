   M S B A M L   `   `   `  ����L  HIZBankingATMAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IZBankingATMAdminIZBankingATMAdmin  5   	   &     IZBankingATMAdmin.AdminDashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   +localclr-namespace:IZBankingATMAdmin  5   	     � Title$   IZ Banking Admin Dashboard��5	   	   $	��700��6,   $
��1200��69    � WindowStartupLocation$ CenterScreen=�6F    � WindowStyle$
 None=�6k    � 
ResizeMode$ NoResize=�6~   .��5
      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ 	#FFE63070��6    � Offset$ 1Q�61   � 5      $ 	#FFFE8704��6   $ 0Q�61   5      .+�5   
   �� $	��650��6   $��Bottom=�6   ���#100E175      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $	��120��6   $��50��6%   $	��Top=�61   $	��5 0q�6I   .+�5      �� $��Images/logo.png��6   $	��120��61   $��50��6=   $
��Fill=�6I   6Z   5      �� 5      $	��100��6   $
��1070��6&   $	��Top=�63   .+�5      �� -   5        	 ��Name$	 BtnExit��5   "   $	��5 5q�5      $��Right=�6&    &  "MaterialDesignFloatingActionButton#��[  6B   $��40��6~   $��40��6�   
 � ToolTip$
 Close��5      ��5   �   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
�������$��30��6N   $��30��6Y   5      5      5      �� 5   
   $	��600��6   $	��Top=�6"   .+�5      �� -   5         ��Name$ WelcomeText��5      $
��Left=�6-   $��Welkom bericht��6H   $��
20,55,0,10q�6^   
�������$��32(�6�   $��Microsoft Sans Serif)�6�   �� 5       -   5        $	 NewCustomerButton��5       $	��300��60   $��50��6<   $��
0 140 0 50q�6H   $��Center=�6\   $
 Maak een nieuwe klant aan��6y   $��Nieuwe klant��6�   $��32(�6�   6�   �� 5!      -   5        $	 CustomerBaseButton��5!      $	��300��61   $��50��6=   $��0 10 0 0q�6I   $��Center=�6[   $#
 Zoek naar een bestaande klant��6x   $��Klantenbestand��6�   $��32(�6�   6�   5"      5#      5$      
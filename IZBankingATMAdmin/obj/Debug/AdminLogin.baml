   M S B A M L   `   `   `  ����L  HIZBankingATMAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IZBankingATMAdminIZBankingATMAdmin  5   	   "    IZBankingATMAdmin.AdminLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   +localclr-namespace:IZBankingATMAdmin  5   	     � Title$   IZ Banking ATM Admin Login��5	   	   $	��450��6,   $	��800��69    � WindowStartupLocation$ CenterScreen=�6E    � WindowStyle$
 None=�6j    � 
ResizeMode$ NoResize=�6}   .��5
      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ 	#FFE63070��6    � Offset$ 1Q�61   � 5      $ 	#FFFE8704��6   $ 0Q�61   5      .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   ���#100E175      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��Images/logo.png��6   $	��300��61   $	��140��6=   $	��Top=�6J   $��30q�6b   $
��Fill=�6n   6   5      �� 5      $	��350��6   .+�5      �� $��20 40q�6   .+�5      �� $��Inloggen��6    $��20q�60   
�������
 �� TextAlignment$
 Center=�6O   $��32(�6f   $��Microsoft Sans Serif)�6t   6�   �� 5      $	 
Horizontal=�6!   $��10q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   
�������6U   �� 5      -   5         ��Name$ employee_numberbx��5   "   $
��10 0q�6=   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Personeelsnummer��6K   
�������$	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD944486�   5      �� 5      $	 
Horizontal=�6!   $��10q�6:   .+�5        $
 Lock=�62   $��25��6>   $��25��6I   
�������6U   G� 5       -   5         G�Name$ 
passwordbx��5    &   $
��10 0q�6:   $ 
**********��6H   
�������$	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   5!      �� 5"      $��10q�6!   $��Center=�6-   .+�5#      �� -   5         ��Name$ BtnLogin��5#   �   $	��100��6!   $��40��6-      MaterialDesignRaisedButton#��[  69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��6m   $��2q�6�   ���#D94448���#D94448
������� � ToolTip$ Login��6�   $��Login��6&  68  5$      5%      5&      �� 5'      $	��100��6   .+�5(      �� -   5        $ BtnExit��5)   "   $��10 20q�5(       & "MaterialDesignFloatingActionButton#��[ 6(   $ Close��5)      ��5(   d   Z� .��5*        $ Close=�6.   
�������$��30��6N   $��30��6Y   5+      5,      5-      5.      5/      
   M S B A M L   `   `   `  ����G  CIZBankingATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IZBankingATMIZBankingATM  5   	   $    IZBankingATM.CustomerDashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:IZBankingATM  5   	     � Title$  IZ Banking ATM Login��5	   	   $	��900��6&   $
��1300��63    � WindowStartupLocation$ CenterScreen=�6@    � WindowStyle$
 None=�6e    � 
ResizeMode$ NoResize=�6x   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��51* �6   .+�5   
   �� $	��900��6   $	��Top=�6   ���	#FF79AAFF$��2��6M   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6.   .+�5      �� $	��350��6   .+�5      �� $��images/logo.png��6   $	��300��61   $	��140��6=   $	��Top=�6J   $��30q�6b   $
��Fill=�6n   6   5      5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   $��175,0,200,0q�6[   .+�5      �� $	��450��6   $	��300��6%   $��	0 120 0 0q�62   .+�5      �� -   5        $��AccountBalance��5      $��Huidige saldo��6/   $	��400��6G   $��80��6S   $��	10 15 2 2q�6_   $��35(�6r   $
��Left=�6�   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��AccontTransactions��5      $��Transacties��63   $	��400��6I   $��80��6U   $��	10 35 2 2q�6a   $��35(�6t   $
��Left=�6�   ���	#FF3C83FD���	#FF367FFF6�   5      �� 5      $	��450��6   $	��300��6%   $��	0 120 0 0q�62   .+�5      �� -   5        $��WithdrawMoney��5      $	��400��6.   $��Geld opnemen��6:   $��80��6Q   $��	10 15 2 2q�6]   $��35(�6p   $
��Left=�6~   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��DepositMoney��5      $	��400��6-   $��Geld storten��69   $��80��6P   $��	10 35 2 2q�6\   $��35(�6o   $
��Left=�6}   ���	#FF3C83FD���	#FF367FFF6�   5      5      5       5!      
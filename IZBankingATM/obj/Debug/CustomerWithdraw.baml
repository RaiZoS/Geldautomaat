   M S B A M L   `   `   `  ����G  CIZBankingATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IZBankingATMIZBankingATM  5   	   #    IZBankingATM.CustomerWithdraw   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:IZBankingATM  5   	     � Title$  IZ Banking ATM Login��5	   	   $	��900��6&   $
��1300��63    � WindowStartupLocation$ CenterScreen=�6@    � WindowStyle$
 None=�6e    � 
ResizeMode$ NoResize=�6x   .��5
      � .+�5   
   �� $	��900��6   $	��Top=�6   ���	#FF79AAFF5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��images/logo.png��6   $	��300��61   $	��140��6=   $	��Top=�6J   $��30q�6b   $
��Fill=�6n   6   �� 5      -   5        $��
BackButton��5      $��Terug��6+   $	��300��6;   $��80��6G   $��	20 15 2 2q�6S   $��35(�6f   $
��Left=�6t   ���	#FFB82C2C���	#FFBD29296�   5      5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   .+�5      �� $	��450��6   $	��550��6%   $��	0 300 0 0q�62   .+�5      �� -   5        $��	Withdraw5��5      $��€5,-��6*   $	��400��69   $��80��6E   $��	10 15 2 2q�6Q   $��35(�6d   $
��Left=�6r   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��
Withdraw10��5      $��€10,-��6+   $	��400��6;   $��80��6G   $��	10 35 2 2q�6S   $��35(�6f   $
��Left=�6t   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��
Withdraw20��5      $��€20,-��6+   $	��400��6;   $��80��6G   $��	10 35 2 2q�6S   $��35(�6f   $
��Left=�6t   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��
Withdraw50��5      $��€50,-��6+   $	��400��6;   $��80��6G   $��	10 35 2 2q�6S   $��35(�6f   $
��Left=�6t   ���	#FF3C83FD���	#FF367FFF6�   5      �� 5      $	��450��6   $	��550��6%   $��	0 300 0 0q�62   .+�5      �� -   5        $��Withdraw100��5      $��€100,-��6,   $	��400��6=   $��80��6I   $��	10 15 2 2q�6U   $��35(�6h   $
��Left=�6v   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��Withdraw200��5      $��€200,-��6,   $	��400��6=   $��80��6I   $��	10 35 2 2q�6U   $��35(�6h   $
��Left=�6v   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -   5        $��Withdraw500��5      $��€500,-��6,   $	��400��6=   $��80��6I   $��	10 35 2 2q�6U   $��35(�6h   $
��Left=�6v   ���	#FF3C83FD���	#FF367FFF6�   �� 5      -	   5         ��Name$ WithdrawInput��5      $�� ��61   $	��275��69   $��80��6E   $��	10 35 2 2q�6Q   $��35(�6d   $
��Left=�6r   
������� �� TextAlignment$ Center=�6�   ���	#FF367FFF6  5      5       �� 5!   
   $��Right=�6   .+�5"      �� -
   5        $��	Withdrawi��5"      $��Opnemen��6&   $	��115��68   $��80��6D   $��10 691 240 2q�6P   $��18(�6f   $
��Left=�6t   ���	#FF3C83FD���	#FF367FFF6�   5#      5$      5%      
   M S B A M L   `   `   `  ����G  CIZBankingATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IZBankingATMIZBankingATM  5   	   "    IZBankingATM.CustomerDeposit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:IZBankingATM  5   	     � Title$  IZ Banking ATM Login��5	   	   $	��900��6&   $
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
   $ Vertical=�6   $��Center=�6,   .+�5      �� $"��Hoeveel geld wilt u storten?��6   $��20q�6<   
������� �� TextAlignment$ Center=�6[   $��60(�6r   $��Microsoft Sans Serif)�6�   6�   �� 5      -   5         ��Name$ DepositInput��5      $�� ��6,   $��40(�64   $
��10 0q�6B    �� TextAlignment$ Center=�6P   ���	#FF363636$	��450��6~   
���   � �� 
CaretBrush �	#FFD94448	 �� SelectionBrush	 �	#FFD94448
�������6  �� 5      -   5        $��DepositButton��5      $��Storten��6*   $	��350��6<   $��80��6H   $��0 15 0 0q�6T   $��35(�6f   ���	#FF3C83FD���	#FF367FFF6�   5      5      5      
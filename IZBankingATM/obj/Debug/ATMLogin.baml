   M S B A M L   `   `   `  ����G  CIZBankingATM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:IZBankingATMIZBankingATM  5   	       IZBankingATM.ATMLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:IZBankingATM  5   	     � Title$  IZ Banking ATM Login��5	   	   $	��900��6&   $
��1300��63    � WindowStartupLocation$ CenterScreen=�6@    � WindowStyle$
 None=�6e    � 
ResizeMode$ NoResize=�6x   .��5
      � .+�5   
   �� $	��900��6   $	��Top=�6   ���	#FF79AAFF5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��images/logo.png��6   $	��300��61   $	��140��6=   $	��Top=�6J   $��30q�6b   $
��Fill=�6n   6   5      5      �� 5   
   $	��650��6   $��Center=�6!   $��Center=�6>   .+�5      �� $��20 40q�6   $��Center=�6(   $��Center=�6E   .+�5      �� $��Enter your PIN��6   $��20q�62   
������� �� TextAlignment$ Center=�6Q   $��60(�6h   $��Microsoft Sans Serif)�6v   6�   �� 5      $ 
Horizontal=�6   $��10q�66   .+�5      �� -   5         ��Name$ account_numberInput��5      $��40(�6;   $
��10 0q�6I   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Rekeningnummer��6W   
�������$	��450��6�   
������� �� 
CaretBrush �	#FFD94448	 �� SelectionBrush	 �	#FFD944486�   5      �� 5      $ 
Horizontal=�6   $��10q�66   .+�5      G� -   5        
 G�Name$
 pincodeInput��5   "   $��40(�68   $
��10 0q�6F   $
 ****��6T   
�������$	��450��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   5      �� 5      $��10q�6   $��Center=�6)   .+�5      �� -   5         ��Name$ ATMLoginBtnEnter��5     $
��Left=�6   $	��Top=�6?   $	��150��6^   $��70��6j      MaterialDesignRaisedButton#��[  6v   $��2q�6�   ���	#99BFBFBF���	#FF52B074���	#FF323232$��ENTER��6  $��24(�6.  5      5      �� 5      $��10q�6   $��Center=�6)   .+�5       �� -   5        $ ATMLoginBtnCancel��5      $
��Left=�6   $	��Top=�6?   $	��150��6^   $��70��6j   #��[  6v   $��2q�6�   ���	#99BFBFBF���	#FFE04343���	#FF323232$��CANCEL��6  $��24(�60  5!      5"      5#      5$      5%      5&      
   M S B A M L   `   `   `  ����M  IMaterialDesignTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MaterialDesignTest.ViewModelMaterialDesignTest.ViewModel  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      "    MaterialDesignTest.LoginCard   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:MaterialDesignTest.ViewModel     5      9system&clr-namespace:System;assembly=mscorlib     5        � DataContext  5      5   /MaterialDesignTest.ViewModel.LoginCardViewModel  5   
    � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   z-depth1   
BlurRadius   ShadowDepth   	Direction   Color  z-depth2  z-depth3  z-depth4  z-depth5 �� 
TargetType  MaterialDesignTextBox �� BasedOn �� Property	 �� Value��%  &	        &	 J     &	 �     &	 �     &	 .    '�� z    7    5   
   $ 5Q�6,   $ 1Q�6;   $	 270Q�6K   $ #CCCCCC��6[     5   
   $ 8Q�6,   $	 2.5Q�6;   $	 270Q�6M   $ #BBBBBB��6]     5   
   $ 14Q�6,   $	 4.5Q�6<   $	 270Q�6N   $ #BBBBBB��6^     5   
   $ 25Q�6,   $ 8Q�6<   $	 270Q�6L   $ #BBBBBB��6\     5   
   $ 35Q�6,   $ 13Q�6<   $	 270Q�6M   $ #BBBBBB��6]   �� 5   
   " ��6   8   .�5      ��  � ��$	 Stretch=�64   5      5      .��5      � -   5        
 �Name$
 	outerGrid��5      $��10, 10, 10, 10q�6   .+�5   
   ��  J� Effect# [ 6    �� CornerRadius$ 7��65   
�������$��10,10,10,10q�6Y   5      � 5    
   -   5        $
 	innerGrid��5       $��10, 0q�6"    � RowDefinitions 5!      �� 5"      $��8* �6    �� 5#      $��1* �6    .+�5%      �� $��1��6    �� 	IsDefault . ��63   �� *LoginCommand+.��5&      �� 	Sign In6%   5'      � 5(      $��0��6    5)      �� 5*      $��1* �6$   �� 5+      $��1* �6$   �� 5,      $��1* �6$   �� 5-      $��1* �6$   .+�5/      �� $��1��6   $��	10,20,0,0q�6%   .��68   
Username6B   �� 50      -   5         ��Name$ Username��50      $��	80,0,0,38q�6H   $��30��6[     MaterialDesignPaper#���  6g   $��1��6�   ��6.   �� *
UserName+6�   �� 51      $��2��6   $��	10,20,0,0q�6%   .��68   
Password6B   G� 52      -   5         G�Name$ PasswordBox��52      $��2��64   $��30��6A   $��	80,0,0,38q�6M   #���  6`   6�   54      59      5;      5<      
   M S B A M L   `   `   `  ����I  EWpfRadioButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfRadioButtonWpfRadioButton  5   	       WpfRadioButton.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfRadioButton     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   6+   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   .+�5      �� $��	SEMÁFORO��6   $��45(�6(    �� TextAlignment$ Center=�66   
����+��6g   5      �� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��* �6'   63   .+�5      �� $��0��6   .+�5      	� -   5        $��50,20,100,80q�5   "   .��5      �� 
���  ��Rojo6;   5      	� 5      -   5        $��50,20,100,80q�5   "   .��5      �� 
��� ���
Amarillo6B   5      	� 5      -   5        $��50,20,100,80q�5   "   .��5      �� 
��� � �Verde6>   5       5"      � 5#      $��1��6   .+�5$      �� $1��+C:\Users\Juan.acevedo\Pictures\semaforo.jpg��6   $	��297��6Q   $	��240��6^    J� RenderTransformOrigin$ 0.558,0.115&�6j   6�   A� 5%      -   5        $
��Rojo��5%      $��Center=�6*   $��60��6G   $��0,64,0,0q�6S   
���   �$	��Top=�6t   $��60��6�   
���  ��$y�Hidden=�6�   A� 5&      -   5        $��Amarillo��5&      $��Center=�6.   $��60��6K   $��	0,130,0,0q�6W   
���   �$	��Top=�6y   $��60��6�   
��� ���$y�Hidden=�6�   A� 5'      -   5        $��Verde��5'      $��Center=�6+   $��60��6H   $��	0,197,0,0q�6T   
���   �$	��Top=�6v   $��60��6�   
��� � �$y�Hidden=�6�   5)      5*      5+      5,      5-      
   M S B A M L   `   `   `  ����C  ?RadioWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:RadioWPFRadioWPF  5   	       RadioWPF.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:RadioWPF     5   	     � Title$  RadioApp��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��86* �6   �� 5      $
��131* �6   .+�5   
   �� -   5         ��Name$ BackgroundMiddle��5      $��Center=�6.   $	��264��6K   
���   �$	��Top=�6g   $	��800��6   $��0,84,0,0q�6�   $��2��6�   ��5      �� 5       �� ImageSource$ /light Woodgrain.jpg��6   5      �� 5   
   -   5        $ BackgroundTop��5      $��Center=�6+   $��84��6H   
���   �$	��Top=�6c   $	��800��6{   ��5      �� 5      $ /Dark Woodgrain.jpg��6    j� Stretch$
 Fill=�6?    j� TileMode$
 None=�6N   5      r� 5   
   -   5         r�Name$ mediaElementCh��5      $
��Left=�6/   $	��100��6J   $��-140,-89,0,0q�6W   $	��Top=�6m   $	��100��6�    r� LoadedBehavior$ Manual=�6�   �� 5   
   -   5        $ BackgroundBottom��5      $��Center=�6.   $��86��6K   
���   �$	��Top=�6f   $	��800��6~   $��	0,176,0,0q�6�   $��1��6�   ��5      �� 5      $ /Dark Woodgrain.jpg��6   5      �� 5   
   $��Center=�6   $	��434��61   $��2��6>   
���   �$	��Top=�6^   $	��800��6v   ���	#FF3C2A19	 J� Opacity$		 0.7Q�6�   �� 5   
   -   5        
 ��Name$
 
channelOne��5      $��	Channel 1��6%   $
��Left=�69   $��
192,69,0,0q�6T   $	��Top=�6h   $��36��6�   $��84��6�   ���	#FF191818
�������$��1��6�   �� 5    
   -   5        $
 playBtn��5       $
��Play��6"   $
��Left=�61   $��	345,2,0,0q�6L   $	��Top=�6_   $��43��6w   $��95��6�   ���	#FF191818
�������$��1��6�   $��16(�6�   	� 5!   
   -   5         	�Name$ radioOn��5!      $��Radio On��6'   $
��Left=�6:   $��311,135,0,0q�6U   $	��Top=�6j   ���	#FFF1F1F16�   	� 5"   
   -   5        $ radioOff��5"      $��	Radio Off��6(   $
��Left=�6<   $��400,135,0,0q�6W   $	��Top=�6l    d� 	IsChecked$
 TrueY�6�   
�������6�   �� 5#   
   -	   5        $
 
channelTwo��5#      $��	Channel 2��6%   $
��Left=�69   $��
305,69,0,0q�6T   $	��Top=�6h   $��37��6�   $��84��6�   ���	#FF191818
�������$��1��6�   �� 5$   
   -
   5        $
 channelThree��5$      $��	Channel 3��6'   $
��Left=�6;   $��
420,69,0,0q�6V   $	��Top=�6j   $��37��6�   $��84��6�   ���	#FF191818
�������$��1��6�   �� 5%   
   -   5        $
 channelFour��5%      $��	Channel 4��6&   $
��Left=�6:   $��
531,69,0,0q�6U   $	��Top=�6i   $��37��6�   $��84��6�   ���	#FF191818
�������$��1��6�   �� 5&   
   -   5         ��Name$ VolumeSlider��5&      $
��Left=�6'   $��263,125,0,0q�6B   $	��Top=�6W   $	��260��6o    � Minimum$ 0Q�6{    � Maximum$	 100Q�6�    �� TickPlacement$ BottomRight=�6�    �� TickFrequency$ 5Q�6�    � Value$	 100Q�6�   
�������$��1��6  �� 5'   
   -   5         ��Name$ RadioDisplay��5'      $��Center=�6*   $��0,84,0,0q�6G   $
��Wrap=�6Y   $	��Top=�6m   $��29��6�   $	��800��6�   ���	#FF191818 �� TextAlignment$ Center=�6�   $��20(�6�   
�������$		 0.8Q�6�   �� 6�    � Language$ en-gb�6�   $�	Radio Off��6  6$  5(      5)      
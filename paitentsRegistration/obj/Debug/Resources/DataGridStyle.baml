   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&    System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �Name	 J� Opacity
 � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName   DataGridStyle �� Padding ��Name � ColumnDefinitions � RowDefinitions    SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name  �� ScrollableHeight! � Maximum" �� Orientation# �� ViewportHeight$ �� ViewportSize*% �� #ComputedVerticalScrollBarVisibility& � Value' �� Mode( �� Mode) �� ScrollableWidth* �� ViewportWidth,+ �� %ComputedHorizontalScrollBarVisibility, �� Triggers- ]� 
Conditions. �� Property/ �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %H  (��       5      $" DataGridSelectAllButtonStyle��"   )&	  �    �� 6   "  ��6{   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      � .+�5	      �� $ Border��6$   #��� ��64    . 6u   � 5
      $ Arrow��6"   
���   �$��Right=�6>   $��8,8,3,3q�6Z   $
	 0.15Q�6k   
 �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver . . �5      �� $ Border��67   # � ��6K    � ��5      P� 5       � �� . . �5      �� $ Border��65   # � ��6I    � ��5      P� 5       � {� .  . �5      �� $ Arrow��6;    � y�$ 	Collapsed=�6N   5      5      5      5      �� 5      "    6"   .�5   
   ��  � �� �#ebb0f96'   �� 5   
    � ��# � ��6'   �� 5   
    � �� �#ebb0f96(   �� 5   
    � ��$ 1q�6,   �� 5    
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5!   
    � �� . 6:   �� 5"   
    �@��PanningMode$
 Both=�65   �� 5#   
    �@��IsFlicksEnabled .  63   �� 5$   
    � �� 5%      �� 5&      "   6"   .R�5'      �� #��z��6   #��z��6G   #��z��6s   # z��6�    . ._�5(      �� $ DG_ScrollViewer��6'   |�.  ��5)      �� 5*   "   " ��62   .R�5+   &   �  5,   *   �� 5-   .   $
��Auto �6?   �� 5.   .   $��* �6?   �� 5/   .   $
��Auto �6?    51   *   �� 52   .   $
��Auto �6<   �� 53   .   $��* �6<   �� 54   .   $
��Auto �6<   .+�56   *   �� #��Z 61   |�.  ��6r   C� *�� $" DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     57   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 58   *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 59   *   $ PART_VerticalScrollBar��64   $��2��6T   #! z  6d   $" Vertical=�6�   $��1��6�   #$ z# 6  #y�z% 6I  & 6�   �� *VerticalOffset+$' OneWay=� �� $( TemplatedParent=�6I  � 5:   *   $��1��6/   $��2��6?    5;   .   �� 5<   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5=   2   $��* �6C   .+�5?   .   �� $ PART_HorizontalScrollBar��68   $��1��6Z   #! z) 6j   $" 
Horizontal=�6�   #$ z* 6  #y�z+ 6D  & 6�   �� *HorizontalOffset+$' OneWay=� �� $( TemplatedParent=�6D  5@   +   5A   '   5B   #   .��5D      �� # z 6-   5E      5F      5G      5I      , 5J   
   ]� 5K      - 5L      �� 5M      . �@��
IsGrouping/ . 66   �� 5N      ". �@%�IsVirtualizingWhenGrouping/ .  6X   ./�5P      ��  � �� .  6B   5Q      5S      5T      
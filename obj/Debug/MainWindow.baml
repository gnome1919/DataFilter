   M S B A M L   `   `   `  ����E  ADataFilter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DataFilter
DataFilter  5   	       DataFilter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DataFilter     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��820��6)   .��5	      � ���	#FFE5E5E5 � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��15 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��15 �6   �� 5      $��30 �6   �� 5      $��15 �6   �� 5      $��30 �6   �� 5      $��15 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��15 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��15 �6   �� 5      $��1* �6    � ColumnDefinitions 5    
   �� 5!      $	��170 �6   �� 5"      $	��140 �6   �� 5#      $��36.576 �6   �� 5$      $��103.424 �6   �� 5%      $	��180 �6   �� 5&      .+�5)   
   �� $��NoWrap=�6   $��Center=�6*   $��20��6E    �� TextAlignment$
 Left=�6Q   $��8��6f   $��0��6s   $��Type of Analysis:��6�   $
��Bold"�6�   $��12(�6�   $��20,5,0,5q�6�   	� 5*   
   -   5        $��MovAveRB��5*       	� 	GroupName$ AnalysisType��6&   $;��5Moving Average and Resample data with equal time step��6?   $��3��6   $��0��6�   $
��Left=�6�   $��20,0,0,0q�6�   $��10��6�   $��Center=�6�   	� 5+   
   -   5        $��SavGolRB��5+      $ AnalysisType��6&   $��0��6?   $��3��6O   $
��Left=�6c   $��20,0,0,0q�6~   $��13��6�   $��Center=�6�   ��5,      �� 5-      $T��NApplying Savitzky-Golay low pass filter on a time series with equal time steps��6   $
��Wrap=�6r   $ Justify=�6�   5/      	� 50   
   -   5        $��LowButRB��50      $ AnalysisType��6&   $��0��6?   $��3��6O   $
��Left=�6c   $��20,0,0,0q�6~   $��16��6�   $��Center=�6�   $��2��6�    d� 	IsChecked$
 TrueY�6�   ��51      �� 52      $Q��KApplying Low pass Butterworth filter on a time series with equal time steps��6   $
��Wrap=�6o   $ Justify=�6�   54      �� 56   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��138��6n   $
 Left=�6z   $��4��6�   $��0��6�   $��Import Input File:��6�   $
��Bold"�6�   $��12(�6�   $��26,5,6,5q�6�   �� 57   
   -   5        $��InputFileTbx��57      $��1��6&   $��3��66   $��Center=�6J   $��20��6g   $��4��6s    �� TextWrapping$ NoWrap=�6�   $��Center=�6�   $	��168��6�    �� 
IsReadOnly . $��
10,5,102,5q�6�   ��6�   �� *Model.DataPeriod+ �� UpdateSourceTrigger$ PropertyChanged=��� 58   
   -   5        $	��...��58      $��3��6   $��Center=�6/   $��4��6L   $��Center=�6Y   $��15��6t   $��20��6   $��6,5,82,5q�6�   6�   �� 5:   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��138��6n   $
 Left=�6z   $��0��6�   $��0��6�   $��Input Format for Time:��6�   $
��Bold"�6�   $��12(�6�   	� 5;   
   -   5        $��	SecondsRB��5;      $ TimeInputFormat��6'   $��Seconds��6C   $��0��6U   $
��Left=�6e   $��1��6�   $��Center=�6�   $��20,5,0,0q�6�    6�   �� *Model.isSecondsChecked+$ PropertyChanged=�6�   	� 5<   
   -   5        $��
FullDateRB��5<      $ TimeInputFormat��6(   $��MM/DD/YYYY hh:mm��6D   $��0��6_   $
��Left=�6o   $��2��6�   $��Center=�6�   $
 TrueY�6�   $��20,5,0,0q�6�   �� 5>   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��150��6n   $
 Left=�6z   $��4��6�   $��4��6�   $��Export Output File:��6�   $
��Bold"�6�   $��12(�6�   �� 5?   
   -   5        $��OutputFileTbx��5?      $��4��6'   $��2��67   $��Center=�6K   $��20��6h   $��4��6t   $ NoWrap=�6�   $��Center=�6�   $	��168��6�    . $��
133,5,41,5q�6�   ��6�   �� *Model.DataPeriod+$ PropertyChanged=��� 5@   
   $	��...��6   $��5��6   $��Center=�6/   $��4��6L   $��Center=�6Y   $��15��6t   $��
126,5,21,5q�6   �� 5B   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��120��6n   $
 Left=�6z   $
��Bold"�6�   $��5��6�   $��0��6�   $��Data Period��6�   �� 5C   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��120��6n   $
 Left=�6z   $
��Bold"�6�   $��6��6�   $��0��6�   $��Number of Data��6�   �� 5E   
   -	   5        $��DataPeriodTbx��5E      $��1��6'   $��Center=�67   $��20��6T   $��5��6a   $ NoWrap=�6n   $��Center=�6�   $	��188��6�   $��	10,2,82,2q�6�   $��3��6�    . 6�   �� 5F   
   -
   5        $��DataNumberTbx��5F      $��1��6'   $��Center=�67   $��20��6T   $��6��6a   $ NoWrap=�6n   $��Center=�6�   $	��120��6�   $
��10,2q�6�    . 6�   �� 5H   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��150��6n   $
 Left=�6z   $
��Bold"�6�   $��5��6�   $��4��6�   $ ��Start Point of Resampling:��6�   �� 5I   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��150��6n   $
 Left=�6z   $
��Bold"�6�   $��6��6�   $��4��6�   $��Resample Interval:��6�   �� 5J   
   -   5        $��ResampleStartTbx��5J      $��5��6*   $��Center=�6:   $��20��6W   $��5��6c   $
 Wrap=�6p   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5K   
   -   5        $��ResampleIntervalTbx��5K      $��5��6-   $��Center=�6=   $��20��6Z   $��6��6g   $
 Wrap=�6t   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5M   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��160��6n   $ Center=�6z   $
��Bold"�6�   $��10��6�   $��4��6�   $��Window Size (Odd Number)��6�   $��15,7,5,3q�6�   �� 5N   
   -   5        $��WindowSizeTbx��5N      $��5��6'   $��Center=�67   $��20��6T   $��10��6`   $
 Wrap=�6n   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5P   
   $��Center=�6   $��NoWrap=�61   $��Center=�6G   $��20��6b   $	��150��6n   $
 Left=�6z   $
��Bold"�6�   $��12��6�   $��4��6�   $��Unchanged Data at First��6�   $
��15,5q�6�   �� 5Q   
   $��Center=�6   $
��15,5q�61   $��NoWrap=�6?   $��Center=�6U   $��20��6p   $	��150��6|   $
 Left=�6�   $
��Bold"�6�   $��13��6�   $��4��6�   $��Unchanged Data at End��6�   �� 5R   
   $��Center=�6   $��	15,3,15,7q�61   $��NoWrap=�6D   $��Center=�6Z   $��20��6u   $	��150��6�   $
 Left=�6�   $
��Bold"�6�   $��14��6�   $��4��6�   $��Degree of Smoothing��6�   �� 5S   
   -   5        $��DataFirstTbx��5S      $��5��6&   $��Center=�66   $��20��6S   $��12��6_   $
 Wrap=�6m   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5T   
   -   5        $��
DataEndTbx��5T      $��5��6$   $��Center=�64   $��20��6Q   $��13��6]   $
 Wrap=�6k   $��Center=�6   $	��120��6�   $
��21,2q�6�   �� 5U   
   -   5        $��SmoothingTbx��5U      $��5��6&   $��Center=�66   $��20��6S   $��14��6_   $
 Wrap=�6m   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5W   
   $��Center=�6   $
��15,5q�61   $��NoWrap=�6?   $��Center=�6U   $��20��6p   $	��150��6|   $
 Left=�6�   $
��Bold"�6�   $��16��6�   $��4��6�   $��Cut-off Frequency��6�   �� 5X   
   $��Center=�6   $
��15,5q�61   $��NoWrap=�6?   $��Center=�6U   $��20��6p   $	��150��6|   $
 Left=�6�   $
��Bold"�6�   $��17��6�   $��4��6�   $��Order of Filter��6�   �� 5Y   
   -   5        $��CutOffFreqTbx��5Y      $��5��6'   $��Center=�67   $��20��6T   $��16��6a   $
 Wrap=�6o   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5Z   
   -   5        $��FilterOrderTbx��5Z      $��5��6(   $��Center=�68   $��20��6U   $��17��6b   $
 Wrap=�6p   $��Center=�6�   $	��120��6�   $
��21,2q�6�   �� 5\   
   -   5        $	��Run��5\      $��3��6   $��Center=�6/   $��19��6L   $��Center=�6Z   $��76��6u   6�   5_      5`      
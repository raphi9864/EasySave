   M S B A M L   `   `   `  ����M  IEasySaveProject-V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EasySaveProject_V2.AddWorkEasySaveProject_V2.AddWork  5      ,    &EasySaveProject_V2.AddWork.AddWorkView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:EasySaveProject_V2.AddWork     5        N� Title$  AddWorkView��5	       N� 
Background �#EAE7DC.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   ��6!   �� *
BackupName+�� 5   
   -   5         ��Name$ txtName��5      $��1��6   6   �� 5   
   $��2��6   ��6!   �� *TargetDirectory+�� 5   
   -   5        $ 	txtTarget��5      $��3��6   6   �� 5   
   $��4��6   ��6!   �� *SourceDirectory+�� 5   
   -   5        $ 	txtSource��5      $��5��6   6   �� 5!   
   $��6��6   ��6!   �� *
BackupType+�� 5"   
   -   5        $ txtType��5"      $��7��6   6   �� 5$   
   -   5        $��9��5$      $��
0,40,0,-40q�6U    J� RenderTransformOrigin$ 0.619,-1.096&�6i   ��68   �� *
Validate+6i   �� 5%   
   $��7��6   $��ExecuteWork��6F   $��
0,87,0,-87q�6\   $ 0.619,-1.096&�6p   ��6   �� *ExecuteWorkCommand+6p   �� 5&   
   $��7��6   $��Settings��6C   $��0,150,0,-150q�6V   $ 0.619,-1.096&�6l   ��6   �� *SettingsCommand+6l   5'      5(      
# JinChengYincang

编写一个进程，能够实现进程隐藏。
创建进程后得到进程的主窗口句柄，并调用API user32.dll。
初始化ListView组件，用于存取当前所有进程，并进行可视化操作(button)。
通过ShowWindow()来指定窗口进程的状态。

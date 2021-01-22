using System;
using Tale.Interface.Enums;
using Veldrid;

namespace Tale.Interface
{
    /// <summary>
    /// 游戏窗体
    /// </summary>
    public interface IGameWindow
    {
        /// <summary>
        /// 渲染
        /// </summary>
        event Action<float> Rendering;
        /// <summary>
        /// 创建设备
        /// </summary>
        event Action<GraphicsDevice, ResourceFactory, Swapchain> GraphicsDeviceCreated;
        /// <summary>
        /// 销毁设备
        /// </summary>
        event Action GraphicsDeviceDestroyed;
        /// <summary>
        /// 窗体大小改变
        /// </summary>
        event Action Resized;
        /// <summary>
        /// 完成一次键盘按键操作(按下-抬起)
        /// </summary>
        event Action<KeyEvent> KeyPressed;
        /// <summary>
        /// 渲染后端
        /// </summary>
        BackendAPI Backend { get; set; }
        /// <summary>
        /// 窗体标题
        /// </summary>
        string Title { get; set; }
        /// <summary>
        /// 窗体宽度
        /// </summary>
        uint Width { get; }
        /// <summary>
        /// 窗体高度
        /// </summary>
        uint Height { get; }
        /// <summary>
        /// 运行游戏窗体
        /// </summary>
        void Run();
    }
}

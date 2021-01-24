using System;
using System.Collections.Generic;
using System.Text;
using Veldrid;

namespace Tale.Interface
{
    /// <summary>
    /// Tale应用
    /// </summary>
    public abstract class IApplication
    {
        /// <summary>
        /// 游戏窗体
        /// </summary>
        IGameWindow Window { get; }
        /// <summary>
        /// 引擎渲染设备
        /// </summary>
        GraphicsDevice GraphicsDevice { get; }
        /// <summary>
        /// 引擎资源工厂
        /// </summary>
        ResourceFactory ResourceFactory { get;  }
        /// <summary>
        /// 引擎主交换链
        /// </summary>
        Swapchain MainSwapchain { get;  }

        /// <summary>
        /// 引擎渲染设备创建完成
        /// </summary>
        /// <param name="gdevice">渲染设备</param>
        /// <param name="factory">资源工厂</param>
        /// <param name="swap">主交换链</param>
        public abstract void OnGraphicsDeviceCreated(GraphicsDevice gdevice, ResourceFactory factory, Swapchain swap);

        /// <summary>
        /// 引擎渲染设备释放完成
        /// </summary>
        public abstract void OnGraphicsDeviceDestroyed();

        /// <summary>
        /// 创建资源
        /// </summary>
        /// <param name="factory">资源工厂</param>
        protected abstract void CreateResources(ResourceFactory factory);

        /// <summary>
        /// 创建交换链资源
        /// </summary>
        /// <param name="factory">资源工厂</param>
        protected abstract void CreateSwapchainResources(ResourceFactory factory);

    }
}

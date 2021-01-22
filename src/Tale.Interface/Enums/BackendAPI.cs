using System;
using System.Collections.Generic;
using System.Text;

namespace Tale.Interface.Enums
{
    /// <summary>
    /// 渲染后端API枚举
    /// </summary>
    public enum BackendAPI
    {
        /// <summary>
        /// 根据系统自动选择最优渲染后端
        /// </summary>
        Default = -1,
        /// <summary>
        /// Direct3D 11
        /// </summary>
        Direct3D11 = 0,
        /// <summary>
        /// Vulkan
        /// </summary>
        Vulkan = 1,
        /// <summary>
        /// OpenGL
        /// </summary>
        OpenGL = 2,
        /// <summary>
        /// Metal
        /// </summary>
        Metal = 3,
        /// <summary>
        /// OpenGLES
        /// </summary>
        OpenGLES = 4
    }
}

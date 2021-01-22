using System;
using System.Collections.Generic;
using System.Numerics;
using Veldrid;

namespace Tale.Core
{
    /// <summary>
    /// 输入跟踪器
    /// </summary>
    public static class InputTracker
    {
        /// <summary>
        /// 当前按下的键盘按键
        /// </summary>
        private static HashSet<Key> _currentlyPressedKeys = new HashSet<Key>();

        /// <summary>
        /// 当前帧的新按下的键盘按键
        /// </summary>
        private static HashSet<Key> _newKeysThisFrame = new HashSet<Key>();

        /// <summary>
        /// 当前按下的鼠标按钮
        /// </summary>
        private static HashSet<MouseButton> _currentlyPressedMouseButtons = new HashSet<MouseButton>();

        /// <summary>
        /// 当前帧的新按下的鼠标按钮
        /// </summary>
        private static HashSet<MouseButton> _newMouseButtonsThisFrame = new HashSet<MouseButton>();

        /// <summary>
        /// 鼠标坐标点
        /// </summary>
        public static Vector2 MousePosition;

        /// <summary>
        /// 帧快照
        /// </summary>
        public static InputSnapshot FrameSnapshot { get; private set; }

        /// <summary>
        /// 获取按键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetKey(Key key)
        {
            return _currentlyPressedKeys.Contains(key);
        }

        /// <summary>
        /// 获取按下的按键
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetKeyDown(Key key)
        {
            return _newKeysThisFrame.Contains(key);
        }

        /// <summary>
        /// 获取鼠标按钮
        /// </summary>
        /// <param name="button"></param>
        /// <returns></returns>
        public static bool GetMouseButton(MouseButton button)
        {
            return _currentlyPressedMouseButtons.Contains(button);
        }

        /// <summary>
        /// 获取鼠标按下的按钮
        /// </summary>
        /// <param name="button"></param>
        /// <returns></returns>
        public static bool GetMouseButtonDown(MouseButton button)
        {
            return _newMouseButtonsThisFrame.Contains(button);
        }

        /// <summary>
        /// 更新此帧的输入信息
        /// </summary>
        /// <param name="snapshot">输入快照</param>
        public static void UpdateFrameInput(InputSnapshot snapshot)
        {
            FrameSnapshot = snapshot;
            _newKeysThisFrame.Clear();
            _newMouseButtonsThisFrame.Clear();

            MousePosition = snapshot.MousePosition;
            for (int i = 0; i < snapshot.KeyEvents.Count; i++)
            {
                KeyEvent ke = snapshot.KeyEvents[i];
                if (ke.Down)
                {
                    KeyDown(ke.Key);
                }
                else
                {
                    KeyUp(ke.Key);
                }
            }
            for (int i = 0; i < snapshot.MouseEvents.Count; i++)
            {
                MouseEvent me = snapshot.MouseEvents[i];
                if (me.Down)
                {
                    MouseDown(me.MouseButton);
                }
                else
                {
                    MouseUp(me.MouseButton);
                }
            }
        }

        /// <summary>
        /// 鼠标按键抬起
        /// </summary>
        /// <param name="mouseButton"></param>
        private static void MouseUp(MouseButton mouseButton)
        {
            _currentlyPressedMouseButtons.Remove(mouseButton);
            _newMouseButtonsThisFrame.Remove(mouseButton);
        }

        /// <summary>
        /// 鼠标按键按下
        /// </summary>
        /// <param name="mouseButton"></param>
        private static void MouseDown(MouseButton mouseButton)
        {
            if (_currentlyPressedMouseButtons.Add(mouseButton))
            {
                _newMouseButtonsThisFrame.Add(mouseButton);
            }
        }

        /// <summary>
        /// 键盘按键抬起
        /// </summary>
        /// <param name="key"></param>
        private static void KeyUp(Key key)
        {
            _currentlyPressedKeys.Remove(key);
            _newKeysThisFrame.Remove(key);
        }

        /// <summary>
        /// 键盘按键按下
        /// </summary>
        /// <param name="key"></param>
        private static void KeyDown(Key key)
        {
            if (_currentlyPressedKeys.Add(key))
            {
                _newKeysThisFrame.Add(key);
            }
        }

    }
}

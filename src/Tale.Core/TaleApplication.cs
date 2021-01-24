using System;
using System.Collections.Generic;
using System.Text;
using Tale.Interface;
using Veldrid;

namespace Tale.Core
{
    public class TaleApplication: IApplication
    {
        public IGameWindow Window { get; }
        public GraphicsDevice GraphicsDevice { get; private set; }
        public ResourceFactory ResourceFactory { get; private set; }
        public Swapchain MainSwapchain { get; private set; }

        public TaleApplication(IGameWindow window)
        {
            Window = window;
            Window.Resized += HandleWindowResize;
            Window.GraphicsDeviceCreated += OnGraphicsDeviceCreated;
            Window.GraphicsDeviceDestroyed += OnGraphicsDeviceDestroyed;
            Window.Rendering += PreDraw;
            Window.Rendering += Draw;
            Window.KeyPressed += OnKeyDown;


        }

        public override void OnGraphicsDeviceCreated(GraphicsDevice gdevice, ResourceFactory factory, Swapchain swap)
        {
            GraphicsDevice = gdevice;
            ResourceFactory = factory;
            MainSwapchain = swap;
            CreateResources(factory);
            CreateSwapchainResources(factory);
        }

        public override void OnGraphicsDeviceDestroyed()
        {
            GraphicsDevice = null;
            ResourceFactory = null;
            MainSwapchain = null;
        }

        protected override void CreateResources(ResourceFactory factory) { }

        protected override void CreateSwapchainResources(ResourceFactory factory) { }

        private void PreDraw(float deltaSeconds)
        {
           // _camera.Update(deltaSeconds);
        }

        protected virtual void Draw(float deltaSeconds) { }

        protected virtual void HandleWindowResize()
        {
           // _camera.WindowResized(Window.Width, Window.Height);
        }

        protected virtual void OnKeyDown(KeyEvent ke) { }

    }
}

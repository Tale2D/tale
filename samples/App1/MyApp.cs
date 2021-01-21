using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SampleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Veldrid;
using Veldrid.SPIRV;

namespace App1
{
    public class MyApp: SampleApplication
    {
        private static CommandList _commandList;



        public MyApp(IApplicationWindow window) : base(window) { }

        protected override void CreateResources(ResourceFactory factory)
        {
          
           
            _commandList = factory.CreateCommandList();
        }

        protected override void Draw(float deltaSeconds)
        {
            // Begin() must be called before commands can be issued.
            _commandList.Begin();

            // We want to render directly to the output window.
            _commandList.SetFramebuffer(GraphicsDevice.SwapchainFramebuffer);
            _commandList.ClearColorTarget(0, RgbaFloat.Pink);

            _commandList.End();
            GraphicsDevice.SubmitCommands(_commandList);

            // Once commands have been submitted, the rendered image can be presented to the application window.
            GraphicsDevice.SwapBuffers();
        }



    }

    struct VertexPositionColor
    {
        public const uint SizeInBytes = 24;
        public Vector2 Position;
        public RgbaFloat Color;
        public VertexPositionColor(Vector2 position, RgbaFloat color)
        {
            Position = position;
            Color = color;
        }
    }
}
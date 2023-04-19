using WindowsInput;
using WindowsInput.Native;

namespace a1qa_L2_UserInterface.Utilities
{
    internal static class InputSimulatorHelper
    {
        private static readonly InputSimulator inputSimulator = new();
        private static readonly int WaitForFileUploadDialogReady = Tests.Test.config.GetValue<int>("WaitForFileUploadDialogReady");

        internal static void UploadImage(string path)
        {
            Thread.Sleep(WaitForFileUploadDialogReady);
            inputSimulator.Keyboard.TextEntry(path);
            inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(WaitForFileUploadDialogReady);
        }
    }
}

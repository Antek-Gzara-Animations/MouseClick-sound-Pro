using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace MouseClick_sound_ProVersion
{
    public partial class Form1 : Form
    {
        //change this variable with every update!!!
        string appVersion = "Version: 1.0 | build: 09.02.2022";


        System.Media.SoundPlayer MouseSound = new System.Media.SoundPlayer(Properties.Resources.click);
        System.Media.SoundPlayer KeyboardSound = new System.Media.SoundPlayer(Properties.Resources.press);

        MouseHook mh;
        LowLevelKeyboardListener listener;

        int MouseMode = 0;
        int KeyboardMode = 0;

        private bool isMouseEnabled = false;
        private bool isKeyboardEnabled = false;

        string customMouseSoundPath = "";

        HelpForm helpform1;

        public Form1()
        {
            InitializeComponent();

            mh = new MouseHook();
            mh.SetHook();
            mh.MouseMoveEvent += mh_MouseMoveEvent;
            mh.MouseClickEvent += mh_MouseClickEvent;
            mh.MouseDownEvent += mh_MouseDownEvent;
            mh.MouseUpEvent += mh_MouseUpEvent;

            listener = new LowLevelKeyboardListener();
            listener.OnKeyPressed += KeyboardPressed;
            listener.HookKeyboard();

            mouseSoundSelection.SelectedIndex = 0;
            keyboardSoundSelection.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //notifyicon.ShowBalloonTip(5000);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            interactiveIcon.BackgroundImage = Properties.Resources.logo1;
            this.Icon = Properties.Resources.icon1;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            interactiveIcon.BackgroundImage = Properties.Resources.logo2;
            this.Icon = Properties.Resources.icon2;
        }

        private void tryMouseSound_Click(object sender, EventArgs e)
        {
            playMouseSound();
        }

        private void tryKeyboardSound_Click(object sender, EventArgs e)
        {
            playKeyboardSound();
        }

        private void mh_MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (isMouseEnabled)
            {
                playMouseSound();
            }
        }

        private void mh_MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (isMouseEnabled)
            {
                if (MouseMode == 0)
                {
                    MouseSound.Stream = Properties.Resources.click2_2;
                    MouseSound.Play();
                }
            }
        }

        private void mh_MouseMoveEvent(object sender, MouseEventArgs e)
        {

        }

        private void mh_MouseClickEvent(object sender, MouseEventArgs e)
        {

        }

        private void KeyboardPressed(object sender, KeyPressedArgs e)
        {
            if (isKeyboardEnabled)
            {
                playKeyboardSound();
            }
        }

        private void switch1_Click(object sender, EventArgs e)
        {
            if (isMouseEnabled)
            {
                isMouseEnabled = false;
                switch1.BackgroundImage = Properties.Resources.off;
            }
            else
            {
                isMouseEnabled = true;
                switch1.BackgroundImage = Properties.Resources.on;
            }
        }

        private void switch2_Click(object sender, EventArgs e)
        {
            if (isKeyboardEnabled)
            {
                isKeyboardEnabled = false;
                switch2.BackgroundImage = Properties.Resources.off;
            }
            else
            {
                isKeyboardEnabled = true;
                switch2.BackgroundImage = Properties.Resources.on;
            }
        }

        private void switch1_DoubleClick(object sender, EventArgs e)
        {
            switch1_Click(sender, e);
        }

        private void switch2_DoubleClick(object sender, EventArgs e)
        {
            switch2_Click(sender, e);
        }

        private void stayOntopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (stayOntopCheckbox.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;   
            }
        }

        private void mouseSoundSelection_DropDownClosed(object sender, EventArgs e)
        {
            switch (mouseSoundSelection.SelectedIndex)
            {
                case 0:
                    MouseMode = 0;
                    break;
                case 1: 
                    MouseMode = 1;
                    break;
                case 2: 
                    MouseMode = 2;
                    break;
                case 3:
                    MouseMode = 3;
                    break;
                case 4:
                    SelectMouseSound();
                    break;
                
            }
        }

        private void SelectMouseSound()
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                customMouseSoundPath = openFileDialog.FileName;
                MouseMode = 4;
            }
            else
            {
                MessageBox.Show("something went wrong!","ERROR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                MouseMode = 0;
            }
        }

        private void SelectKeyboardSound()
        {

        }

        private void playMouseSound()     //sound
        {
            
            if (MouseMode == 0)
            {
                MouseSound.Stream = Properties.Resources.click2_1;
                MouseSound.Play();
            }
            else if (MouseMode == 1)
            {
                MouseSound.Stream = Properties.Resources.click3;
                MouseSound.Play();
            }
            else if (MouseMode == 2)
            {
                MouseSound.Stream = Properties.Resources.click4;
                MouseSound.Play();
            }
            else if (MouseMode == 3)
            {
                MouseSound.Stream = Properties.Resources.click_old;
                MouseSound.Play();
            }
            else if(MouseMode == 4)
            {
                try
                {
                    MouseSound = new SoundPlayer(customMouseSoundPath);
                    MouseSound.Play();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MouseMode = 0;
                }
            }
            
        }

        private void playKeyboardSound()
        {
            /*
            sound 1
            sound 2
            sound 3
            sound 4
            sound 5
            random sound
            custom sound (must be .wav)
            */
            if (KeyboardMode == 0)
            {
                KeyboardSound.Stream = Properties.Resources.press2;
                KeyboardSound.Play();
            }
            else if (KeyboardMode == 1)
            {
                KeyboardSound.Stream = Properties.Resources.press3;
                KeyboardSound.Play();
            }
            else if (KeyboardMode == 2)
            {
                KeyboardSound.Stream = Properties.Resources.press4;
                KeyboardSound.Play();
            }
            else if (KeyboardMode == 3)
            {
                KeyboardSound.Stream = Properties.Resources.press5;
                KeyboardSound.Play();
            }
            else if (KeyboardMode == 4)
            {
                KeyboardSound.Stream = Properties.Resources.press;
                KeyboardSound.Play();
            }
            else if (KeyboardMode == 5)
            {
                switch (new Random().Next(0, 3))
                {
                    case 0:
                        KeyboardSound.Stream = Properties.Resources.press2;
                        break;
                    case 1:
                        KeyboardSound.Stream = Properties.Resources.press3;
                        break;
                    case 2:
                        KeyboardSound.Stream = Properties.Resources.press4;
                        break;
                    case 3:
                        KeyboardSound.Stream = Properties.Resources.press5;
                        break;
                }

                KeyboardSound.Play();
            }

            
        }


        private void keyboardSoundSelection_DropDownClosed(object sender, EventArgs e)
        {
            switch (keyboardSoundSelection.SelectedIndex)
            {
                case 0:
                    KeyboardMode = 0;
                    break; 
                case 1:
                    KeyboardMode = 1;
                    break;
                case 2:
                    KeyboardMode = 2;
                    break;
                case 3:
                    KeyboardMode = 3;
                    break;
                case 4:
                    KeyboardMode = 4;
                    break;
                case 5:
                    KeyboardMode = 5;
                    break;
                case 6:
                    SelectKeyboardSound();
                    break;

            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            helpform1 = new HelpForm(appVersion);
            helpform1.Show();
        }
    }
}


#region kod ze strony: https://github.com/kellman616/TouchScreenControlEverythingDemo/blob/master/Demo1_Detect_Mouse_Position_And_Click_Event/Demo_mousehook_csdn/Form1.cs

public class Win32Api
{
    [StructLayout(LayoutKind.Sequential)]
    public class POINT
    {
        public int x;
        public int y;
    }
    [StructLayout(LayoutKind.Sequential)]
    public class MouseHookStruct
    {
        public POINT pt;
        public int hwnd;
        public int wHitTestCode;
        public int dwExtraInfo;
    }
    public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern bool UnhookWindowsHookEx(int idHook);
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);
}


public class MouseHook
{
    private Point point;
    private Point Point
    {
        get { return point; }
        set
        {
            if (point != value)
            {
                point = value;
                if (MouseMoveEvent != null)
                {
                    var e = new MouseEventArgs(MouseButtons.None, 0, point.X, point.Y, 0);
                    MouseMoveEvent(this, e);
                }
            }
        }
    }
    private int hHook;
    private const int WM_MOUSEMOVE = 0x200;
    private const int WM_LBUTTONDOWN = 0x201;
    private const int WM_RBUTTONDOWN = 0x204;
    private const int WM_MBUTTONDOWN = 0x207;
    private const int WM_LBUTTONUP = 0x202;
    private const int WM_RBUTTONUP = 0x205;
    private const int WM_MBUTTONUP = 0x208;
    private const int WM_LBUTTONDBLCLK = 0x203;
    private const int WM_RBUTTONDBLCLK = 0x206;
    private const int WM_MBUTTONDBLCLK = 0x209;
    public const int WH_MOUSE_LL = 14;
    public Win32Api.HookProc hProc;
    public MouseHook()
    {
        this.Point = new Point();
    }
    public int SetHook()
    {
        hProc = new Win32Api.HookProc(MouseHookProc);
        hHook = Win32Api.SetWindowsHookEx(WH_MOUSE_LL, hProc, IntPtr.Zero, 0);
        return hHook;
    }
    public void UnHook()
    {
        Win32Api.UnhookWindowsHookEx(hHook);
    }
    private int MouseHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        Win32Api.MouseHookStruct MyMouseHookStruct = (Win32Api.MouseHookStruct)Marshal.PtrToStructure(lParam, typeof(Win32Api.MouseHookStruct));
        if (nCode < 0)
        {
            return Win32Api.CallNextHookEx(hHook, nCode, wParam, lParam);
        }
        else
        {
            if (MouseClickEvent != null)
            {
                MouseButtons button = MouseButtons.None;
                int clickCount = 0;
                switch ((Int32)wParam)
                {
                    case WM_LBUTTONDOWN:
                        button = MouseButtons.Left;
                        clickCount = 1;
                        MouseDownEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                    case WM_RBUTTONDOWN:
                        button = MouseButtons.Right;
                        clickCount = 1;
                        MouseDownEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                    case WM_MBUTTONDOWN:
                        button = MouseButtons.Middle;
                        clickCount = 1;
                        MouseDownEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                    case WM_LBUTTONUP:
                        button = MouseButtons.Left;
                        clickCount = 1;
                        MouseUpEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                    case WM_RBUTTONUP:
                        button = MouseButtons.Right;
                        clickCount = 1;
                        MouseUpEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                    case WM_MBUTTONUP:
                        button = MouseButtons.Middle;
                        clickCount = 1;
                        MouseUpEvent(this, new MouseEventArgs(button, clickCount, point.X, point.Y, 0));
                        break;
                }

                var e = new MouseEventArgs(button, clickCount, point.X, point.Y, 0);
                MouseClickEvent(this, e);
            }
            this.Point = new Point(MyMouseHookStruct.pt.x, MyMouseHookStruct.pt.y);
            return Win32Api.CallNextHookEx(hHook, nCode, wParam, lParam);
        }
    }

    public delegate void MouseMoveHandler(object sender, MouseEventArgs e);
    public event MouseMoveHandler MouseMoveEvent;

    public delegate void MouseClickHandler(object sender, MouseEventArgs e);
    public event MouseClickHandler MouseClickEvent;

    public delegate void MouseDownHandler(object sender, MouseEventArgs e);
    public event MouseDownHandler MouseDownEvent;

    public delegate void MouseUpHandler(object sender, MouseEventArgs e);
    public event MouseUpHandler MouseUpEvent;


}

#endregion

#region kod ze strony: http://www.dylansweb.com/2014/10/low-level-global-keyboard-hook-sink-in-c-net/
public class LowLevelKeyboardListener
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_SYSKEYDOWN = 0x0104;

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);

    public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    public event EventHandler<KeyPressedArgs> OnKeyPressed;

    private LowLevelKeyboardProc _proc;
    private IntPtr _hookID = IntPtr.Zero;

    public LowLevelKeyboardListener()
    {
        _proc = HookCallback;
    }

    public void HookKeyboard()
    {
        _hookID = SetHook(_proc);
    }

    public void UnHookKeyboard()
    {
        UnhookWindowsHookEx(_hookID);
    }

    private IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN)
        {
            int vkCode = Marshal.ReadInt32(lParam);

            if (OnKeyPressed != null) { OnKeyPressed(this, new KeyPressedArgs(KeyInterop.KeyFromVirtualKey(vkCode))); }
        }

        return CallNextHookEx(_hookID, nCode, wParam, lParam);
    }
}

public class KeyPressedArgs : EventArgs
{
    public Key KeyPressed { get; private set; }

    public KeyPressedArgs(Key key)
    {
        KeyPressed = key;
    }
}
#endregion
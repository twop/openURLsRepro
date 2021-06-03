using AppKit;
using Foundation;

namespace openURLsTest
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        
        public override void OpenUrls(NSApplication application, NSUrl[] urls)
        {
            throw new System.Exception("opened with: " + urls[0].AbsoluteString);
        }
    }
}

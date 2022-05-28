using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System.Profile;
using Windows.UI.Notifications;
using Windows.UI.Shell;

namespace Toast_Sample
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();

            // Listen to notification activation
            ToastNotificationManagerCompat.OnActivated +=
                ToastNotificationManagerCompat_OnActivated;

            //ToastNotificationManagerCompat.OnActivated += toastArgs =>
            //{
            //    // Obtain the arguments from the notification
            //    ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

            //    // Obtain any user input (text boxes, menu selections) from the notification
            //    ValueSet userInput = toastArgs.UserInput;

            //    // Need to dispatch to UI thread if performing UI operations
            //    Application. Dispatcher.Invoke(delegate
            //    {
            //        // TODO: Show the corresponding content
            //        MessageBox.Show("Toast activated. Args: " + toastArgs.Argument);
            //    });
            //};
        }

        private void ToastNotificationManagerCompat_OnActivated
            (ToastNotificationActivatedEventArgsCompat e)
        {
            object val;

            string argument = e.Argument;

            if (string.IsNullOrWhiteSpace(value: argument) == false)
            {
                MessageBox.Show(text: argument);
            }

         //   MessageBox.Show(e.UserInput.Values.Count.ToString());
            if (e.UserInput.Values.Count > 0)
            {
                    e.UserInput.TryGetValue("tbReply", out val);
                    MessageBox.Show(val.ToString());
            }
        }

        private void SendToastButtonByText_Click(object sender, EventArgs e)
        {
            Uri audioPath = 
                new Uri(@"E:\MyFolder\Music\BackgroundMusic\bm1.mp3");

            //    ToastContent toastContent = new ToastContent()
            //    {
            //        Visual = new ToastVisual()
            //        {

            //        },

            //        Audio = new ToastAudio()
            //        {
            //            Src = audioPath
            //        }
            //};


            new ToastContentBuilder()
               .AddHeader("11", "عنوان", "title")
               .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
               .AddText("ایمیل با موفقیت ارسال گردید")
               .AddAttributionText("گروه نرم افزاری آپنا")
               .Show();
        }

        private void SendToastButtonByImage_Click(object sender, EventArgs e)
        {
            string imagePath =
                  $"{Application.StartupPath}Images\\Background.png";

            Uri imageUri =
                new Uri(imagePath);



            new ToastContentBuilder()
               .AddHeader("11", "عنوان", "title")
               .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
               .AddText("ایمیل با موفقیت ارسال گردید")
               .AddAttributionText("گروه نرم افزاری آپنا")

               .AddInlineImage(imageUri)

               .Show();
        }

        private void SendToastButtonByLogo_Click(object sender, EventArgs e)
        {
            string imagePath =
                        $"{Application.StartupPath}Images\\MyPic2.jpeg";

            Uri imageUri = new Uri(imagePath);

            new ToastContentBuilder()
                       .AddHeader("11", "عنوان", "title")
                       .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
                       .AddText("ایمیل با موفقیت ارسال گردید")
                       .AddAttributionText("گروه نرم افزاری آپنا")

                       .AddAppLogoOverride(imageUri, ToastGenericAppLogoCrop.Circle)

                       .Show()
                       ;
        }

        private void SendToastButtonByButton_Click(object sender, EventArgs e)
        {

            var toast = new ToastContentBuilder()
                .AddHeader("11", "عنوان", "title")

                .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
                .AddText("ایمیل با موفقیت ارسال گردید")

                .AddAttributionText("گروه نرم افزاری آپنا")

                .AddButton(new ToastButton()
                    .SetContent("Reply")
                    .AddArgument("action", "reply")
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("Like")
                    .AddArgument("action", "like")
                    .SetBackgroundActivation())

                .AddButton(new ToastButton()
                    .SetContent("View")
                    .AddArgument("action", "viewImage")
                    .AddArgument("imageUrl", @"E:\MyFolder\Apna\Logo.jpg"))
                    .SetBackgroundActivation()
                ;

            toast.Show();
        }

        private void SendToastButtonByHeroImage_Click(object sender, EventArgs e)
        {
            string imagePath =
                 $"{Application.StartupPath}Images\\Background.png";

            Uri imageUri = new Uri(imagePath);

            new ToastContentBuilder()
                .AddHeader("11", "عنوان", "title")
                .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
                .AddText("ایمیل با موفقیت ارسال گردید")
                .AddAttributionText("گروه نرم افزاری آپنا")
          
                .AddHeroImage(imageUri)
                
                .Show()
                ;
        }

        private void SendToastButtonByTextBox_Click(object sender, EventArgs e)
        {
            var toast = new ToastContentBuilder()
                   .AddHeader(id: "11", title: "عنوان", arguments: "title")

                   .AddText(text: "ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
                   .AddText(text: "ایمیل با موفقیت ارسال گردید")

                   .AddAttributionText(text: "گروه نرم افزاری آپنا")

                   .AddInputTextBox(id: "tbReply", placeHolderContent: "Type a response")
                   ;

            toast.Show();

        }

        private void SendToastButton_Click(object sender, EventArgs e)
        {
            string imagePath =
               $"{Application.StartupPath}Images\\Background.png";

            string logoPath =
              $"{Application.StartupPath}Images\\MyPic2.jpeg";


            Uri imageUri = new Uri(imagePath);

            Uri logoUri = new Uri(logoPath);

           
            var toast = new ToastContentBuilder()
                   .AddHeader("11", "عنوان", "title")

                   .AddText("ارسال ایمیل")//, AdaptiveTextStyle.Body, false, 1, 1, AdaptiveTextAlign.Center, "fa-IR")
                   .AddText("ایمیل با موفقیت ارسال گردید")

                   .AddAttributionText("گروه نرم افزاری آپنا")

                   .AddInlineImage(imageUri)

                   .AddAppLogoOverride(logoUri, ToastGenericAppLogoCrop.Circle)


                   .AddButton(new ToastButton()
                       .SetContent("Reply")
                       .AddArgument("action", "reply")
                       .SetBackgroundActivation())

                   .AddButton(new ToastButton()
                       .SetContent("Like")
                       .AddArgument("action", "like")
                       .SetBackgroundActivation())

                   .AddButton(new ToastButton()
                       .SetContent("View")
                       .AddArgument("action", "viewImage")
                       .AddArgument("imageUrl", @"E:\MyFolder\Apna\Logo.jpg"))
                       .SetBackgroundActivation()

                   .AddInputTextBox(id: "tbReply", placeHolderContent: "Type a response")
                   ;

            toast.Schedule(DateTimeOffset.Now.AddSeconds(60));
           
            toast.Show();
        }
        public void SendUpdatableToastWithProgress()
        {
            // Define a tag (and optionally a group) to uniquely identify the notification, in order update the notification data later;
            string tag = "weekly-playlist";
            string group = "downloads";

            // Construct the toast content with data bound fields
            var content = new ToastContentBuilder()
                .AddText("Downloading your weekly playlist...")
                .AddVisualChild(new AdaptiveProgressBar()
                {
                    Title = "Weekly playlist",
                    Value = new BindableProgressBarValue("progressValue"),
                    ValueStringOverride = new BindableString("progressValueString"),
                    Status = new BindableString("progressStatus")
                })
                .GetToastContent();

            // Generate the toast notification
            var toast = new ToastNotification(content.GetXml());

            // Assign the tag and group
            toast.Tag = tag;
            toast.Group = group;

            // Assign initial NotificationData values
            // Values must be of type string
            toast.Data = new NotificationData();
            toast.Data.Values["progressValue"] = "0.6";
            toast.Data.Values["progressValueString"] = "15/26 songs";
            toast.Data.Values["progressStatus"] = "Downloading...";

            // Provide sequence number to prevent out-of-order updates, or assign 0 to indicate "always update"
            toast.Data.SequenceNumber = 1;

            // Show the toast notification to the user
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }
        public void SendUpdatableToastWithProgress1()
        {
            //// Define a tag (and optionally a group) to uniquely identify the notification, in order update the notification data later;
            //string tag = "weekly-playlist";
            //string group = "downloads";

            //// Construct the toast content with data bound fields
            //var content = new ToastContent()
            //{
            //    Visual = new ToastVisual()
            //    {
            //        BindingGeneric = new ToastBindingGeneric()
            //        {
            //            Children =
            //    {
            //        new AdaptiveText()
            //        {
            //            Text = "Downloading your weekly playlist..."
            //        },

            //        new AdaptiveProgressBar()
            //        {
            //            Title = "Weekly playlist",
            //            Value = new BindableProgressBarValue("progressValue"),
            //            ValueStringOverride = new BindableString("progressValueString"),
            //            Status = new BindableString("progressStatus")
            //        }
            //    }
            //        }
            //    }
            //};

            //// Generate the toast notification
            //var toast = new ToastNotification(content.GetXml());

            //// Assign the tag and group
            //toast.Tag = tag;
            //toast.Group = group;

            //// Assign initial NotificationData values
            //// Values must be of type string
            //toast.Data = new NotificationData();
            //toast.Data.Values["progressValue"] = "0.6";
            //toast.Data.Values["progressValueString"] = "15/26 songs";
            //toast.Data.Values["progressStatus"] = "Downloading...";

            //// Provide sequence number to prevent out-of-order updates, or assign 0 to indicate "always update"
            //toast.Data.SequenceNumber = 1;

            //// Show the toast notification to the user
            //ToastNotificationManager.CreateToastNotifier().Show(toast);


            // In a real app, these would be initialized with actual data
            string title = "Andrew Bares";
            string content = "Cannot wait to try your UWP app!";

            // Construct the toast content
            ToastContent toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = title
                            },

                            new AdaptiveText()
                            {
                                Text = content
                            }
                        }
                    }
                }
            };

            bool supportsCustomAudio = true;

            // If we're running on Desktop before Version 1511, do NOT include custom audio
            // since it was not supported until Version 1511, and would result in a silent toast.
            if (AnalyticsInfo.VersionInfo.DeviceFamily.Equals("Windows.Desktop")
                && !ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 2))
            {
                supportsCustomAudio = false;
            }

            if (supportsCustomAudio)
            {
                string audioPath =
                        $"{Application.StartupPath}Audio\\audio1.m4a";
                toastContent.Audio = new ToastAudio()
                {
                   

               
               // Src = new Uri("ms-appx:///Assets/Audio/audio1.m4a")
                Src = new Uri(audioPath)

                    // Supported audio file types include
                    // .aac
                    // .flac
                    // .m4a
                    // .mp3
                    // .wav
                    // .wma
                };
            }
            ToastContentBuilder toastContentBuilder = new ToastContentBuilder();
            
            // And create the toast notification
            ToastNotification notification = new ToastNotification(toastContent.GetXml());

            // And then send the toast
            ToastNotificationManager.CreateToastNotifier().Show(notification);
        }

        private async void SampleForm_Load(object sender, EventArgs e)
        {
            //SendUpdatableToastWithProgress1();
         
        }
    }
}

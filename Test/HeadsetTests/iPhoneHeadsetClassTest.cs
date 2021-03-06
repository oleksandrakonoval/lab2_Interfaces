﻿using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;

namespace SimCorp.IMS.Test.HeadsetTests {
    [TestClass]
    public class TestOutputForiPhoneHeadset {
        [TestMethod]
        public void iPhoneHeadset_IsPlay() {
            // Arrange / Act
            IOutput output = new OutputMock();
            IPlayback playback = new iPhoneHeadset(output);
            playback.Play(output);

            //Assert
            Assert.IsTrue(output.Output.ToString().Contains("iPhoneHeadset"));
        }
    }
}


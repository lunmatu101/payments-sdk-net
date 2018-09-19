﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.Payments.Client.Model;
using System.Reflection;
using CM.Payments.Client.Enums;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
	[TestClass, ExcludeFromCodeCoverage]
	public partial class WireTransferDetailsRequestTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void WireTransferDetailsRequest()
		{
			var obj = new WireTransferDetailsRequest
			{
				CallbackUrl = "Lorum_612",
				CancelledUrl = "Lorum_542",
				ExpiredUrl = "Lorum_582",
				FailedUrl = "Lorum_813",
				PurchaseId = "Lorum_228",
				SuccessUrl = "Lorum_851"
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.CallbackUrl, deserialized.CallbackUrl);
			Assert.AreEqual(obj.CancelledUrl, deserialized.CancelledUrl);
			Assert.AreEqual(obj.ExpiredUrl, deserialized.ExpiredUrl);
			Assert.AreEqual(obj.FailedUrl, deserialized.FailedUrl);
			Assert.AreEqual(obj.PurchaseId, deserialized.PurchaseId);
			Assert.AreEqual(obj.SuccessUrl, deserialized.SuccessUrl);
		}
	}
}
using Foundation;

namespace Binding
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SampleFrameworkVersionNumber;
		[Field ("SampleFrameworkVersionNumber", "__Internal")]
		double SampleFrameworkVersionNumber { get; }

		// extern const unsigned char [] SampleFrameworkVersionString;
		[Field ("SampleFrameworkVersionString", "__Internal")]

		//byte[]
		 NSString SampleFrameworkVersionString { get; }
	}
}

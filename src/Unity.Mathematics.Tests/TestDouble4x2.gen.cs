// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble4x2
    {
        [Test]
        public void double4x2_operator_equal_wide_wide()
        {
            double4x2 a0 = double4x2(492.15758275061728, -495.20632027797694, 227.45765195947968, -147.37405950733182, -222.68201909897942, 64.093720704360749, -23.890404473939157, -16.8197190839889);
            double4x2 b0 = double4x2(192.56880888369346, -235.61102472786376, -254.04311740307281, -412.62472052715009, 471.90480945627428, -6.4727852374654162, -339.10237447316865, 488.1875700839737);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4x2 a1 = double4x2(163.23210890741655, -165.27101071424363, 470.87767980568003, -423.94255967808078, 109.63436918595539, 462.69031283943468, -335.38147727371262, 357.23446934168896);
            double4x2 b1 = double4x2(-379.5965842584132, -308.41700258311675, -82.333374300195544, -102.92108087563935, 226.51573835430463, -356.90132896830391, -362.91277544708589, -427.89843746083716);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4x2 a2 = double4x2(1.5455777652308598, -347.38824741327585, -114.47217302884542, 435.84865804940864, 194.23808607563285, 138.76554710174241, -467.34914205379278, 370.43337767684523);
            double4x2 b2 = double4x2(466.65013978753711, -102.79904680270658, -43.355954428834821, 85.045664111639212, -91.127054972167628, 422.19208856215334, -477.43130873024057, 1.8770024785198984);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4x2 a3 = double4x2(476.70826147343416, 320.55264702465047, -498.59197377534207, 92.4169581366782, 104.51136856177425, 166.75460608618084, -204.73343024250744, 434.75675674656259);
            double4x2 b3 = double4x2(312.5800799394865, 254.59934365684137, 352.72583763335172, 62.490957050812881, 119.71476059766246, -511.05808639482507, -302.47273053902791, -371.76924365189359);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x2_operator_equal_wide_scalar()
        {
            double4x2 a0 = double4x2(-303.2300766926399, 451.52631327674089, -253.65587413201848, -105.20363502632995, -500.6910920090466, -426.19248338518315, 159.87609656149334, -59.558379439431405);
            double b0 = (123.5445759871717);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4x2 a1 = double4x2(-57.477391031327386, 406.51375861024189, 370.88599866017978, -172.03530629539642, 455.40001198993991, -11.338988547836891, 363.93823044557973, -27.150561106927);
            double b1 = (-182.0497396840014);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4x2 a2 = double4x2(-325.97606507221985, 180.19686635779067, -374.12832015293105, -439.35894295170851, -126.54608899287234, -197.2617896521752, -227.15933357326281, -479.8991937487848);
            double b2 = (-290.35904254129116);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4x2 a3 = double4x2(-439.77767750237962, -224.51705013239621, -422.83322616239695, -450.19627043707123, -20.106708774392814, 297.37999906082632, 185.9665759475746, -102.97598962810633);
            double b3 = (-495.23734902555);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x2_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double4x2 b0 = double4x2(19.952187785856495, -185.79199346610903, 407.8136052600172, -87.2766969610363, -206.27469382354741, 160.503138855334, -274.77081478516141, -2.6315281403397535);
            bool4x2 r0 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (448.35453602688131);
            double4x2 b1 = double4x2(-410.03524251004461, 247.32901465489022, 355.53915350303942, -298.06671180299793, 414.10151429385951, -481.30262707234482, 196.55074438664633, 34.60100008668428);
            bool4x2 r1 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (113.76156645350227);
            double4x2 b2 = double4x2(-386.45337861890596, -124.49174672201821, 243.8866447153905, -492.6181826501238, 145.424413033493, 421.55070968230757, -95.409988209330493, 336.80928746648567);
            bool4x2 r2 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (209.58380589707929);
            double4x2 b3 = double4x2(487.441424358376, 161.80653365040507, 149.84247095409899, 225.723996505944, -71.21880176999548, 85.780251781353854, 192.547256797807, -49.887493395194156);
            bool4x2 r3 = bool4x2(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x2_operator_not_equal_wide_wide()
        {
            double4x2 a0 = double4x2(430.8425316432689, 104.69001798736394, 225.80243478799355, -310.57017841496048, -418.61945815506363, 304.12820281839379, -509.32682561749908, -160.53807719076895);
            double4x2 b0 = double4x2(210.02470622305975, -55.203330304102678, -269.92533672504373, -234.54673372700194, 25.917412054686565, -63.726991444699024, -484.55371092471933, -425.333599050219);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4x2 a1 = double4x2(-203.30197606016975, -505.76325368590807, 162.17220623892365, 1.1561973100324394, 65.662074358045174, 102.78780250567377, 172.93008120960099, 26.621009123800832);
            double4x2 b1 = double4x2(-53.274394775402925, 328.1944192984115, 15.963139303011417, 461.71412417931208, -113.36304455313973, -240.07297264787974, 495.11916970420589, 203.5583661550462);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4x2 a2 = double4x2(235.12595259171258, 128.54198533321824, -354.99697630246959, 334.35948220564023, -495.83200692377613, 468.30740163675853, 458.37094733601941, 299.93733300824522);
            double4x2 b2 = double4x2(340.49345103860526, -241.90719448863865, 459.56982896270688, 213.0737384357833, -384.7828506831, -255.07233846144396, 477.66343115161328, -248.03662621604121);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4x2 a3 = double4x2(43.12718560319729, -354.71349994964595, -145.2871955117617, 390.80186218340032, -303.13149108697263, 391.13459533785215, 139.2868607692825, 104.52318506339714);
            double4x2 b3 = double4x2(-407.92344565313471, -199.78886971240343, 151.84326488889906, -97.120607659742518, 154.97589380805187, -172.83452065886672, 441.5027942329192, -401.73862785926957);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double4x2_operator_not_equal_wide_scalar()
        {
            double4x2 a0 = double4x2(-16.914588697680529, 168.83411486858233, -462.71352145760949, 130.30776959765137, 214.50161443208424, -440.26328178879959, -197.12796053529155, -169.09985860115842);
            double b0 = (-145.37277109239847);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4x2 a1 = double4x2(-386.61117595555783, -270.26885593601912, -403.96372313236992, -269.80570877241234, 299.65422763473089, -71.750904831919286, -432.75573917513515, -457.36312100727258);
            double b1 = (-281.02101362916687);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4x2 a2 = double4x2(-13.519590622521719, 185.042454567292, -482.53069351731364, 116.39514427836764, 511.73495578753523, 230.50753628020527, 100.27476768394683, 129.68240863163135);
            double b2 = (273.87305773136814);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4x2 a3 = double4x2(321.17879048044733, 140.33521921016984, 369.2123617461009, 453.81121489676241, -333.66624871532724, -373.93775218256644, 150.20429451307484, -442.16476627912596);
            double b3 = (-220.63900409482375);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double4x2_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double4x2 b0 = double4x2(-57.196896341255353, -382.4325279586169, 97.820359990848374, -161.46364529499022, -458.39563367254829, -499.61786364932448, 327.92217818271467, 367.57121699283425);
            bool4x2 r0 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (59.7863667289663);
            double4x2 b1 = double4x2(-209.58068118318016, -62.580453186566217, -479.97497604786184, -49.494519495169868, -114.68521338081229, 109.93924599044919, -176.28482755286842, -347.48529903380449);
            bool4x2 r1 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (85.540928165214609);
            double4x2 b2 = double4x2(-356.65954868712441, -104.24357490625397, -133.54918605347592, 243.53971135036079, 13.141311890045813, -379.98594754747393, -41.281226892620907, 87.911684792447659);
            bool4x2 r2 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (-339.07727996403224);
            double4x2 b3 = double4x2(-371.82034533648766, 333.14425936953364, 294.81196011920088, -187.14565977228136, 220.19225774528093, -228.18207250730234, -499.72373914146971, 97.4059055305114);
            bool4x2 r3 = bool4x2(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
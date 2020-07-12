using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinProject
{
    public enum PixelType
    {
        TRANSPARENT = 0,
        TRANSLUCENT = 254,
        OPAQUE = 255
    }

    public enum BodyPart {
        TopHead,
        BottomHead,
        TopHelmet,
        BottomHelmet,
        RHead,
        Face,
        LHead,
        BHead,
        RHelmet,
        FHelmet,
        LHelmet,
        BHelmet,
        RLeg_Top,
        RLeg_Foot,
        TopTorso,
        BottomTorso,
        RArm_Top,
        RArm_Hand,
        RLeg_Out,
        RLeg_Front,
        RLeg_In,
        RLeg_Back,
        RTorso,
        Torso,
        LTorso,
        BTorso,
        RArm_Out,
        RArm_Front,
        RArm_In,
        RArm_Back,
        RLeg_SecondLayer,
        Torso_SecondLayer,
        RArm_SecondLayer,
        LLeg_SecondLayer,
        LLeg,
        LArm,
        LArm_SecondLayer
    }
}

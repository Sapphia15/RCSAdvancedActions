using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RCSAdvancedActions
{
    public class RCSAdvancedActionModule : PartModule
    {

        ModuleRCS moduleRCS;

        public override void OnStart(StartState state)
        {
            moduleRCS = part.FindModuleImplementing<ModuleRCS>();
        }

        [KSPAction("Toggle Attitude Control")]
        public void ToggleAttitudeControlAction(KSPActionParam param)
        {
            //If any attitude control is enabled, turn it all off. Otherwise, turn it all on
            //For some reason it seems like on and off are inverted? (on == false and off == true)
            bool attitudeControl = moduleRCS.enableYaw && moduleRCS.enablePitch && moduleRCS.enableRoll;
            moduleRCS.enableYaw = !attitudeControl;
            moduleRCS.enablePitch = !attitudeControl;
            moduleRCS.enableRoll = !attitudeControl;
        }


    }
}

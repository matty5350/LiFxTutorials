/**
* <author>Ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxNPCmod))
{
    new ScriptObject(LiFxNPCmod)
    {
    };
}

package LiFxNPCmod

{
    function LiFxNPCmod::setup() {
        LiFx::registerCallback($LiFx::hooks::onServerCreatedCallbacks, Datablock, LiFxNPCmod);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxNPCmod::ObjectsTypesBrotherhoodSoldier(), LiFxNPCmod);

    }
    function LiFxNPCmod::version() {
        return "0.0.1";
    }
  
        function LiFxNPCmod::ObjectsTypesBrotherhoodSoldier() {
        return new ScriptObject(ObjectsTypesBrotherhoodSoldier : ObjectsTypes)
        {
            id = 2500; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Brotherhood Soldier";
            ParentID = 61;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 1000;
            BackgrndImage = "";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
};
activatePackage(LiFxNPCmod);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxNPCmod);
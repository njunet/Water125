var OxO5352=["attachEvent","on","addEventListener","detachEvent","removeEventListener","Object","width","left=","availWidth",",top=","availHeight",",width=",",height=",",resizable=1,status=1","","window has been blocked","dialogArguments","focus","unload","DIV","document","top","cssText","style","position:absolute;left:0px;top:0px;width:100%;height:100%;filter:alpha(opacity=30);background-color:#808080;","MozOpacity","innerHTML","\x26nbsp;","onclick","body","returnValue","undefined","closed","html","string","-1","ok","yes","true","1","length","value","%3b","s:","n:","b:","boolean","number",";","="," ","startOffset","endOffset","startContainer","endContainer","None","Control","Text","nodeType","parentNode","nodeValue","childNodes"];var id_nsc=0x0; function NotifySelectionChange(Ox1d9){ clearTimeout(id_nsc) ; id_nsc=setTimeout(function (){ editor.UpdateToolbar() ; editor.LogSavePoint() ;} ,parseInt(Ox1d9)||0x64) ;}  ; function AttachDomEvent(obj,name,Ox1d6){if(obj[OxO5352[0x0]]){ obj.attachEvent(OxO5352[0x1]+name,Ox1d6) ;} ;if(obj[OxO5352[0x2]]){ obj.addEventListener(name,Ox1d6,true) ;} ;}  ; function DetachDomEvent(obj,name,Ox1d6){if(obj[OxO5352[0x3]]){ obj.detachEvent(OxO5352[0x1]+name,Ox1d6) ;} ;if(obj[OxO5352[0x4]]){ obj.removeEventListener(name,Ox1d6,true) ;} ;}  ;var lastmodalwindowtime=0x0; function openModalWindow(Oxbb,Ox320,Ox321,Ox322){ lastmodalwindowtime= new Date().getTime() ;if(Ox321==null|| typeof (Ox321)==OxO5352[0x5]){var Ox2e=(Ox321||{})[OxO5352[0x6]]||0x190;var h=(Ox321||{})[OxO5352[0x6]]||0x12c; Ox321=OxO5352[0x7]+(screen[OxO5352[0x8]]-Ox2e)/0x2+OxO5352[0x9]+(screen[OxO5352[0xa]]-h)/0x2+OxO5352[0xb]+Ox2e+OxO5352[0xc]+h+OxO5352[0xd] ;} ;var Ox18e; Ox18e=window.open(Oxbb,OxO5352[0xe],Ox321) ;if(Ox18e==null){throw ( new Error(-0x1,OxO5352[0xf]));} ; Ox18e[OxO5352[0x10]]=Ox320 ; AttachDomEvent(window,OxO5352[0x11],Ox324) ; AttachDomEvent(editwin,OxO5352[0x11],Ox324) ; AttachDomEvent(Ox18e,OxO5352[0x12],Ox326) ;var Ox74=null;var Ox323=false;var div; div=window[OxO5352[0x15]][OxO5352[0x14]].createElement(OxO5352[0x13]) ; div[OxO5352[0x17]][OxO5352[0x16]]=OxO5352[0x18] ; div[OxO5352[0x17]][OxO5352[0x19]]=0.3 ; div[OxO5352[0x1a]]=OxO5352[0x1b] ; div[OxO5352[0x1c]]=Ox324 ; window[OxO5352[0x15]][OxO5352[0x14]][OxO5352[0x1d]].appendChild(div) ;if( typeof (Ox18e[OxO5352[0x1e]])!=OxO5352[0x1f]){ Ox18e[OxO5352[0x1e]]=Ox74 ;} ;return Ox18e; function Ox324(){if(!Ox18e){return ;} ;if(Ox18e[OxO5352[0x20]]){ Ox328() ;return ;} ; setTimeout(Ox325,0x1) ; function Ox325(){try{ Ox18e.focus() ;} catch(x){} ;}  ;}  ; function Ox326(){try{ Ox74=Ox18e[OxO5352[0x1e]] ;} catch(x){} ;try{ DetachDomEvent(Ox18e,OxO5352[0x12],Ox326) ;} catch(x){} ; setTimeout(function Ox327(){if(Ox323){return ;} ;if(!Ox18e){return ;} ;if(!Ox18e[OxO5352[0x20]]){try{ AttachDomEvent(Ox18e,OxO5352[0x12],Ox326) ;} catch(x){} ;return ;} ; Ox328() ;} ,0x64) ;}  ; function Ox328(){if(Ox323){return ;} ; Ox323=true ;if(div){ window[OxO5352[0x15]][OxO5352[0x14]][OxO5352[0x1d]].removeChild(div) ; div[OxO5352[0x1c]]=null ; div=null ;} ;try{ DetachDomEvent(editwin,OxO5352[0x11],Ox324) ; DetachDomEvent(window,OxO5352[0x11],Ox324) ;} catch(x){} ;try{ DetachDomEvent(Ox18e,OxO5352[0x12],Ox326) ;} catch(x){} ;try{try{if(Ox74==null){if( typeof (Ox18e[OxO5352[0x1e]])!=OxO5352[0x1f]){ Ox74=Ox18e[OxO5352[0x1e]] ;} ;} ;} catch(x){} ;var Ox31a= new Object(); Ox31a[OxO5352[0x1e]]=Ox74 ; Ox322(Ox74,Ox31a) ;} finally{ Ox18e=null ; Ox74=null ;} ;}  ;}  ; function GetSavePoint(){return {html:editdoc[OxO5352[29]][OxO5352[26]]};}  ; function RestoreSavePoint(Oxa8){ editdoc[OxO5352[0x1d]][OxO5352[0x1a]]=Oxa8[OxO5352[0x21]] ;}  ; function ToBoolean(Ox224){if( typeof (Ox224)==OxO5352[0x22]){switch(Ox224.toLowerCase()){case OxO5352[0x27]:case OxO5352[0x26]:case OxO5352[0x25]:case OxO5352[0x1]:case OxO5352[0x24]:case OxO5352[0x23]: Ox224=true ;break ;default: Ox224=false ;;;;;;;;} ;} ;return Ox224?true:false;}  ;var _data={}; function GetData(name){return _data[name];}  ; function SetData(name,Ox5b){ _data[name]=Ox5b ;}  ;var _log_sps=[];var _log_index=-0x1; function Log_CanUndo(){if(_log_index==-0x1){return false;} ;return _log_index>0x0;}  ; function Log_Undo(){if(!Log_CanUndo()){return false;} ; _log_index-- ;return true;}  ; function Log_CanRedo(){if(_log_index==-0x1){return false;} ;return _log_index+0x1<_log_sps[OxO5352[0x28]];}  ; function Log_Redo(){if(!Log_CanRedo()){return false;} ; _log_index++ ;return true;}  ; function Log_GetSavePoint(){return _log_sps[_log_index];}  ; function Log_SetSavePoint(Ox257){if(_log_index>=0x0&&_log_index<_log_sps[OxO5352[0x28]]){ _log_sps[_log_index]=Ox257 ;} ;}  ; function Log_AddSavePoint(Ox257){if(_log_index==-0x1){ _log_sps[0x0]=Ox257 ; _log_index=0x0 ;return ;} ;if(_log_sps[_log_index][OxO5352[0x21]]==Ox257[OxO5352[0x21]]){ _log_sps[_log_index]=Ox257 ;return ;} ; _log_index++ ;if(Log_CanRedo()){ _log_sps[OxO5352[0x28]]=_log_index ;} ; _log_sps[_log_index]=Ox257 ;}  ;var _states={};var _statenames=[]; function GetState(name,Ox25c){var Ox5b=_states[name];if( typeof (Ox5b)==OxO5352[0x1f]){return Ox25c;} ;return Ox5b;}  ; function SetState(name,Ox5b){ _states[name]=Ox5b ;for(var i=0x0;i<_statenames[OxO5352[0x28]];i++){if(_statenames[i]==name){return ;} ;} ; _statenames[_statenames[OxO5352[0x28]]]=name ;if(initcomplete){ statectrl[OxO5352[0x29]]=GetStateExpression() ;} ;}  ; function GetStateExpression(){if(_statenames[OxO5352[0x28]]==0x0){return OxO5352[0xe];} ;var Ox25=OxO5352[0xe];for(var i=0x0;i<_statenames[OxO5352[0x28]];i++){var name=_statenames[i];var Ox5b=GetState(name);switch( typeof (Ox5b)){case OxO5352[0x22]: Ox5b=OxO5352[0x2b]+escape(Ox5b).replace(/;/g,OxO5352[0x2a]) ;break ;case OxO5352[0x2f]: Ox5b=OxO5352[0x2c]+Ox5b ;break ;case OxO5352[0x2e]: Ox5b=OxO5352[0x2d]+Ox5b ;break ;default:continue ;;;;;} ;if(Ox25!=OxO5352[0xe]){ Ox25+=OxO5352[0x30] ;} ; Ox25+=name+OxO5352[0x31]+Ox5b ;} ;return Ox25;}  ; function SetStateExpression(Ox260){var arr=Ox260.split(OxO5352[0x30]);for(var i=0x0;i<arr[OxO5352[0x28]];i++){var Ox25=arr[i];if(Ox25==OxO5352[0xe]){continue ;} ;var Ox2f=Ox25.split(OxO5352[0x31]);if(Ox2f[OxO5352[0x28]]!=0x2){continue ;} ;var n=Ox2f[0x0];var Ox9=Ox2f[0x1];switch(Ox9.substr(0x0,0x2)){case OxO5352[0x2d]: Ox9=ToBoolean(Ox9.substr(0x2,Ox9[OxO5352[0x28]]-0x2)) ;break ;case OxO5352[0x2b]: Ox9=unescape(Ox9.substr(0x2,Ox9[OxO5352[0x28]]-0x2).replace(/\+/g,OxO5352[0x32])) ;break ;case OxO5352[0x2c]: Ox9=parseFolat(Ox9.substr(0x2,Ox9[OxO5352[0x28]]-0x2)) ;break ;;;;} ; SetState(n,Ox9) ;} ;}  ; function RestoreStates(){ SetStateExpression(statectrl.value) ; ExecCommand_ToggleBorder() ;if(_get_FullPage()==true){ ExecCommand_FullPage() ;} ; FixActiveTabUI() ; SyncToFrame() ;}  ; function Range_GetSelectionType(Ox176){var Ox32a=Ox176[OxO5352[0x33]];var Ox32b=Ox176[OxO5352[0x34]];var Ox32c=Ox176[OxO5352[0x35]];var Ox32d=Ox176[OxO5352[0x36]];if(Ox32a==Ox32b&&Ox32c==Ox32d){return OxO5352[0x37];} ;if(Ox32b-Ox32a==0x1&&Ox32c==Ox32d){return OxO5352[0x38];} ;return OxO5352[0x39];}  ; function Range_IsNodeSelected(Ox176,Ox27f){if(Ox176[OxO5352[0x35]]!=Ox176[OxO5352[0x36]]){return false;} ;var Oxf1=Range_GetSelectionType(Ox176);if(Oxf1==OxO5352[0x37]){return false;} ;if(Oxf1==OxO5352[0x38]){return Range_GetParentElement(Ox176)==Ox27f;} ;if(Ox176[OxO5352[0x33]]!=0x0){return false;} ;if(Ox176[OxO5352[0x35]][OxO5352[0x3a]]==0x3){if(Ox176[OxO5352[0x35]][OxO5352[0x3b]]!=Ox27f){return false;} ;if(Ox176[OxO5352[0x34]]!=Ox176[OxO5352[0x35]][OxO5352[0x3c]][OxO5352[0x28]]+0x1){return false;} ;return true;} ;return Ox176[OxO5352[0x34]]==Ox27f[OxO5352[0x3d]][OxO5352[0x28]]+0x1;}  ; function Range_GetParentElement(Ox176){var Ox32a=Ox176[OxO5352[0x33]];var Ox32b=Ox176[OxO5352[0x34]];var Ox32c=Ox176[OxO5352[0x35]];var Ox32d=Ox176[OxO5352[0x36]];if(Ox32a==Ox32b&&Ox32c==Ox32d){if(Ox32c[OxO5352[0x3a]]==0x3){return Ox32c[OxO5352[0x3b]];} ;return Ox32c;} ;if(Ox32b-Ox32a==0x1&&Ox32c==Ox32d){return Ox32c[OxO5352[0x3d]][Ox32a];} ;var Ox330=[];for(var Ox331=Ox32c;Ox331!=null;Ox331=Ox331[OxO5352[0x3b]]){ Ox330[Ox330[OxO5352[0x28]]]=Ox331 ;} ; Ox330.reverse() ;var Ox332=[];for(var Ox331=Ox32c;Ox331!=null;Ox331=Ox331[OxO5352[0x3b]]){ Ox332[Ox332[OxO5352[0x28]]]=Ox331 ;} ; Ox332.reverse() ;var Ox333=null;var Ox195=Math.min(Ox330[OxO5352[0x28]],Ox332.length);for(var i=0x0;i<Ox195;i++){if(Ox330[i]==Ox332[i]){ Ox333=Ox330[i] ;} else {break ;} ;} ;if(Ox333[OxO5352[0x3a]]==0x3){ Ox333=Ox333[OxO5352[0x3b]] ;} ;return Ox333;}  ;
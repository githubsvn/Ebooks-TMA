function gIT(o){if(o.nodeType==3)return o.nodeValue;if('SCRIPT'==o.tagName)return '';var t='';var cn=o.childNodes;for(var i=0;i<cn.length;i++)t+=gIT(cn[i]);return t;}
var itxturl='http://codeproject.us.intellitxt.com/v3/door.jsp?ts='+(new Date()).getTime()+'&ipid=5102&refurl='+document.location.href.replace(/\&/g,'%26').replace(/\'/g, '%27').replace(/\"/g, '%22');
try {
document.write('<s'+'cript language="javascript" src="'+itxturl+'"></s'+'cript>');
}catch(e){}

local mt = {__index = function(t)return t.___ end}
function setDefault(t, d)
	t.___ = d
	setmetatable(t, mt)
end

tab = {x=10, y=20}
tab2 = {}
setDefault(tab, 0)
setDefault(tab2, 1)
print(tab.x, tab.z) --> 10 0
print(tab2.x) --> 1
## 需求

### 清除git仓库的所有提交记录

```Shell
# 1.切换的新分支
git checkout --orphan latest
# 2.提交
git commit -am "commit message"
# 3.删除主分支
git branch -D main
# 4.重命名
git branch -m main
# 5.强制提交
git push -f origin main
```

## Warning 

### LF will be replaced by CRLF the next time Git touches it  

#### 原因
 Windows与Linux换行符不一致

#### 解决方案
1. Windows  `git config --global core.autocrlf true`
2. Linux `git config --global core.autocrlf input`
<template>
	<view class="container">
		<scroll-view scroll-x="true" class="ctab" >
			<view v-for="(item,index) in dtab" :key="index" class="ctabidx">
				<text>{{item.name}}</text>
			</view>
		</scroll-view>
		<!-- <view class="intro">本项目已包含uni ui组件，无需import和注册，可直接使用。在代码区键入字母u，即可通过代码助手列出所有可用组件。光标置于组件名称处按F1，即可查看组件文档。</view>
		<text class="intro">详见：</text>
		 <uni-link :href="href" :text="href"></uni-link> -->
	</view>
</template>

<script>
	import $http from "../../api/myrequest.js";
	
	export default {
		data() {
			return {
				href: 'https://uniapp.dcloud.io/component/README?id=uniui',
				dtab:[
					{name:"进度概略"},
					{name:"客户查询"},
					{name:"单号查询"},
					{name:"型号查询"},
					{name:"信息录入"},
					{name:"订单修改"}
					
				]
			}
		},
		onLoad() {
			this._init()
		},
		methods: {
        _init(){
		  console.log($http.c);
		
		
		
		}
		}
	}
</script>

<style>
	.container1 {
		padding: 20px;
		font-size: 14px;
		line-height: 24px;
	}
    .ctab{
		width: 100%;
		height: 80rpm;
		white-space: nowrap;
	}
	.ctabidx{
		display: inline-block;
		padding: 10rpx 20rpx;
	}
</style>

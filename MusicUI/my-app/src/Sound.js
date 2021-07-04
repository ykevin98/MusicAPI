import React from "react";
import PropTypes from "prop-types";
import axios from 'axios';

class Sound extends React.Component{
    /*
    state = {
        sounds: [].fill(null) 
    }
    */
    state = {
        message: ""
    }
    
    constructor (props){
        super(props);
        this.state = {
            message: ""
        };
        /*
        this.state = {
            sounds: []
        }
        */
       
    }
    /*
    getSoundApi(){
        
        axios.get('https://localhost:44361/api/Music/AllSound')
        .then(response => {
            const sounds = response.data;
            this.setState({ sounds });
        })
        
        const response = axios.get('https://localhost:44361/api/Music/GetSounds');
        this.setState({ sounds: response.data });
    }
    */
    
    getString(){
        /*
        const response = axios.get('https://localhost:44361/api/Music/GetString');
        this.setState({ message: response.data });
        */
       /*
        axios.get('https://localhost:44361/api/Music/GetString')
        .then(response => {
            const sounds = response.data;
            this.setState({ message: response.data });
        })
        */
       axios.get('https://localhost:44361/api/Music/GetString')
       .then(response => {
           const message = response.data;
           this.setState({ message });
       })
    }
    /*
    render(){
        return(
            <ul>
                <li>{this.sounds.fileName}</li>
                <h4>Hello World</h4>
            </ul>
        );
    } 
    */
    render(){
        return(
            <h4>{this.state.message}</h4>
        );
    } 
}
/*
Sound.propTypes = {
    id: PropTypes.string,
    filePath: PropTypes.string,
    fileName: PropTypes.string,
    fileSize: PropTypes.number,
    modified: PropTypes.object,
    modifiedBy: PropTypes.string
};
*/
export default Sound;
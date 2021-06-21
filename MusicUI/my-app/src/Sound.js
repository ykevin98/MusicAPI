import React from "react";
import PropTypes from "prop-types";
import axios from 'axios';

class Sound extends React.Component{
    state = {
        sounds: []
    }
    
    getSoundApi(){
        /*
        axios.get('https://localhost:44361/api/Music/AllSound')
        .then(response => {
            const sounds = response.data;
            this.setState({ sounds });
        })
        */
        const response = axios.get('https://localhost:44361/api/Music/AllSound');
        this.setState({ sounds: response.data });
    }

    render(){
        return(
            <ul>
                <li>{sounds.fileName}</li>
                <h4>Hello World</h4>
            </ul>
        );
    }  
}

Sound.propTypes = {
    id: PropTypes.string,
    filePath: PropTypes.string,
    fileName: PropTypes.string,
    fileSize: PropTypes.number,
    modified: PropTypes.object,
    modifiedBy: PropTypes.string
};

export default Sound;